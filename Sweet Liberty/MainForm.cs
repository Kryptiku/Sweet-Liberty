using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Timers;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Runtime.ConstrainedExecution;

namespace SweetLiberty
{
    public partial class MainForm : Form
    {


        private Location currentLocation;
        private string NorthExit;
        private string EastExit;
        private string SouthExit;
        private string WestExit;
        
        private Dictionary<string, Location> dictLocations = new Dictionary<string, Location>();
        private Dictionary <string, Item> dictItems = new Dictionary<string, Item>();

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int timerIndex = 0;
        private string textToAdd = "";

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font FsSinclair;

        public MainForm()
        {
            InitializeComponent();
            SetCustomFont();
            timer.Interval = 1; // Interval in milliseconds
            timer.Tick += TimerTick;
        }

        private void Go(string Direction)
        {
            // has to be an exit here else button would not be enabled
            Location checkLocation = currentLocation;
            switch (Direction)
            {
                // CheckExit will change currentLocation to new value
                case "north": CheckExit(dictLocations[NorthExit]); break;
                case "east": CheckExit(dictLocations[EastExit]); break;
                case "south": CheckExit(dictLocations[SouthExit]); break;
                case "west": CheckExit(dictLocations[WestExit]); break;
            }
            if (checkLocation != currentLocation)
            {
                CheckArea(currentLocation);
                CheckMusic(currentLocation.Name);
                
            }
        }

        private void CheckExit(Location exitLocation)
        {
            if (exitLocation.ItemRequired == null)
            {
                currentLocation = exitLocation;
            }
            else
            {
                if (exitLocation.ItemRequired == Player.ItemInHand)
                {
                    currentLocation = exitLocation;
                }
                else
                {
                    DisplayStory($"\nYou need the {exitLocation.ItemRequired.Name} in your hand to enter {exitLocation.DisplayName}.");
                }
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // Ticks decide when it is appropriate to do actions

            if (timerIndex < textToAdd.Length)
            {
                display.Text += textToAdd[timerIndex];
                timerIndex++;
                DisableButton(buttonUp);
                DisableButton(buttonDown);
                DisableButton(buttonLeft);
                DisableButton(buttonRight);
                DisableButton(buttonHold);
                DisableButton(buttonPickUp);
            }
            else
            {
                EnableButton(buttonHold);
                EnableButton(buttonPickUp);
                DisplayCompass();
                timer.Stop(); 
            }
        }

        private void SetCustomFont()
        {
            byte[] fontData = Properties.Resources.FSSinclairTrial_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.FSSinclairTrial_Bold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.FSSinclairTrial_Bold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            FsSinclair = new Font(fonts.Families[0], 16.0F);
        }

        private void MainFormLoad(object sender, EventArgs e){CreateGame();}
        private void ButtonUpClick(object sender, EventArgs e) { Sound.PlaySoundEffect("upSound.wav"); Go("north"); }
        private void ButtonRightClick(object sender, EventArgs e) { Sound.PlaySoundEffect("rightSound.wav"); Go("east"); }
        private void ButtonDownClick(object sender, EventArgs e) { Sound.PlaySoundEffect("downSound.wav"); Go("south"); }
        private void ButtonLeftClick(object sender, EventArgs e) { Sound.PlaySoundEffect("leftSound.wav"); Go("west"); }
        private void ButtonPickUpClick(object sender, EventArgs e) { TakeItem(); }
        private void ButtonHoldClick(object sender, EventArgs e) { HoldItem(); }


        private void DisplayStory(string AddText, bool clear = false)
        {
            if (clear)
            {
                display.Text = string.Empty;
            }

            textToAdd = AddText;
            timerIndex = 0;
            timer.Start();

        }

        private void CreateGame()
        {
            display.Font = FsSinclair;

            PlayMusic("Music/Long Night of Solace.mp3");
            Sound.PlaySoundEffect("Sound Effects/terminal.wav");

            // Items
            dictItems.Add("Breaker", new Item("Breaker", "An automatic shotgun. Good for killing bugs and robots."));
            dictItems.Add("Automaton IFF", new Item("Automaton IFF", "An Identification Friend or Foe. Automatons would see me as another one of them"));
            dictItems.Add("Terminid Sample", new Item("Terminid Sample", "A bug sample. Used to be what we came here for."));
            dictItems.Add("Stim", new Item("Stim", "Great for healing wounds. Might be useful to keep this around."));

            // Logs
            dictItems.Add("Log 3AD", new Log("Log 3AD", "A log left behind by some scientists.",  "Log 3AD. The Terminid population is decreasing, but we don't know why this is happening. We need to run more tests. This cannot happen."));

            // Locations 
            dictLocations.Add("StartingArea", new Location("StartingArea",
                        "The Cold Wasteland",
                        "-- Log 1 --\n" +
                        "This is Squadron Alpha of the Executor of Family Values\n" +
                        ".\n.\n.\nOr what's left of it.\n" +
                        "Two of my squadmates abandoned me on the Lacaille Sector, in Lesath...\n" +
                        "And my other squadmate got caught in an Eagle Napalm Strike during extraction... He didn't make it.\n" +
                        "It's really cold. Blizzards everywhere. Pitch dark. Can't see shit.\n" +
                        "Automatons everywhere. Gotta hide. They must be searching for me.\n" +
                        "Saw a Stim. Probably a good idea to pick it up.",
                        "Outpost", "", "", "",  // N E S W
                         new List<Item> { dictItems["Stim"] }));

            dictLocations.Add("Outpost", new Location("Outpost",
                       "Abandoned Outpost",
                       "-- Log 2 --\n" +
                       "Found an abandoned outpost. Looks like it was thrashed around.\n" +
                       "Frozen bodies everywhere. Nothing useful. Chunks of metal are rooted deep into the snow.\n" +
                       "Could get inside. Might find something. Can't tell if there's anything hiding inside.",
                       "OutpostRoom", "", "StartingArea", "Stronghold"));

            dictLocations.Add("OutpostRoom", new Location("OutpostRoom",
                       "Outpost Room",
                       "-- Log 3 --\n" +
                       "Went inside an abandoned outpost room. Seems it was scavenged about.\n" +
                       "Whole place is empty. Can't see anything. Save for a terminal emitting light on the far side of the room.\n" +
                       "Probably something useful there-- shit!\n" +
                       "Ah, it's just a rat. Fuck.", 
                       "OutpostTerminal", "", "Outpost", ""));

            dictLocations.Add("OutpostTerminal", new Location("OutpostTerminal",
                       "Outpost Terminal",
                       "-- Log 4 -- \n" +
                       "Went to the terminal. It might be on, but any touch on it doesn't make it respond.\n" +
                       "Found a Breaker underneath the terminal. A fully loaded automatic shotgun. Might be useful to pick up.",
                       "", "", "OutpostRoom", "",
                       new List<Item> { dictItems["Breaker"] }));

            dictLocations.Add("Stronghold", new Location("Stronghold",
                       "Automaton Stronghold",
                       "-- Log 8 --\n" +
                       "Found what appears to be an Automaton Stronghold. Multiple of them in visual. Need to scope the area out.\n" +
                       "Scaled up to get a bit closer. Needed a better view of the stronghold.\n" +
                       "The base is so massive. There may be something useful there, but how am I gonna get in?\n" +
                       "Ah shit, there's an automaton squadron nearby. I need to lay low.\n" +
                       "Shit! Enemy tango might have spotted me. Eyes glowed bright red. Should be fine. I ducked behind a rock for cover.\n" +  
                       "This place is extremely dangerous. Need to consider if I should enter now.",
                       "AutomatonTerminal", "Outpost", "", "CrashSite"));

            dictLocations.Add("AutomatonTerminal", new Location("AutomatonTerminal",
                       "Automaton Terminal",
                       "-- Log 9 -- \n" +
                       "There's a lot of them here... Lined up like soldiers. Good thing I'm not seen as a foe.\n" +
                       "Nearing the end of this hallway... Huh...\n" +
                       "Looks like an Automaton control center for the ship deployements. There's a terminal in the center.\n" +
                       "I just need to do this little button combination... and...\n" +
                       "There. I'm leaving. I'm finally going home.",
                       "", "", "", "",
                       null, null,
                       "Decided to approach the terminal. It's a big risk, but I'll have to take it.\n" +
                       "They spotted me! I'm taking fire! I might not be able to hold on!\n" +
                       "Sweet Liberty! A grenade!\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1..."));

            dictLocations.Add("Ship", new Location("Ship",
                       "Destroyer Ship",
                       "-- Log 10 --\n" +
                       "Delivered the sample to the higher ups. They seemed really happy about my performance.\n" +
                       "I also heard the two squadmates that left us were executed for being traitors.\n" +
                       "Seems right now I'm just assigned to paperwork as a promotion.\n" +
                       "Might not be so bad after all...\n" +
                       "Sweet Liberty...",
                       "", "", "", "", //N E S W
                       null, null, // items and itemRequired
                       "...I am deemed as a traitor.\n" +
                       "They still asked me for the Terminid sample. The reason why they sent us there in the first place.\n" +
                       "I wasn't able to retrieve it.\n" +
                       "YOU HAVE BEEN MARKED AS A TRAITOR. PLEASE STAND STILL IN THE DESIGNATED AREA.\n" +
                       "LAUNCHING 120MM HE BARRAGE IN 3... 2... 1...\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1..."));

            dictLocations.Add("CrashSite", new Location("CrashSite",
                       "Crash Site",
                       "-- Log 5 --\n" +
                       "Found an escape pod.It crashed deep into the snow.\n" +
                       "An automaton's guarding it. Looks like a suicide bomber.\n" +
                       "Might be advisable to hold a weapon before going in.\n",
                       "EscapePod", "StrongHold", "", ""));

            dictLocations.Add("EscapePod", new Location("EscapePod",
                       "Escape Pod",
                       "-- Log 6 --\n" +
                       "Killed the automaton easily. Tried to open the pod. Doesn't budge.\n" +
                       "Dug out some snow. Found what seems to be an Automaton IFF.\n" +
                       "Could help me get through some Automaton patrols. They'll see me and they'll think I'm a friendly." +
                       "Would be helpful to pick it up.",
                       "", "", "CrashSite", "Burrow",
                       new List<Item> { dictItems["Automaton IFF"] },
                       null,
                       "-- Log 6 --\n" +
                       "I've decided to face the--\n" +
                       "Close-range explosion detected.\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1..."));

            dictLocations.Add("Burrow", new Location("Burrow",
                       "Terminid Burrow",
                       "-- Log 7 --\n" +
                       "I found this small opening... Looks like it was burrowed through.\n" +
                       "I'm not entirely sure what's inside... Should I check it out?",
                       "Nest", "EscapePod", "", ""));

            dictLocations.Add("Nest", new Location("Nest",
                       "Terminid Nest",
                       "-- Log 8 --\n" +
                       "Log 8. I crawled through this opening... Looks like it was burrowed through.\n" +
                       "Wait... is that a...\n" +
                       "It's a Bile Spewer... But it doesn't seem to be attacking.\n" +
                       "Maybe it doesn't mean any harm?",
                       "TimeSkip", "", "Burrow", "",
                       null, null,
                       "-- Log 8 --\n" +
                       "I crawled through this opening... And I hear a lot of slitehring sounds...\n" +
                       "Wait... is that a...\n" +
                       "It's a Bile Spewer! Agghhh!\n" +
                       "Unexpected log termination."));

            dictLocations.Add("TimeSkip", new Location("TimeSkip",
                       "Time Skip",
                       "-- Log 29 --\n" +
                       "It's almost been a month, but I got used to life here in Lesath.\n" +
                       "These Terminids that I found seem to see me as their leader...\n" +
                       "They also reproduced so fast that they've taken over the underground area of this planet...\n" +
                       "Maybe living like this... Isn't so bad after all..."));

       


            Player.Name = "Alpha-Three";
            Player.Health = 100;
            Player.Strength = 50;
            currentLocation = dictLocations["StartingArea"];

            Play();
            
        }

        private void TakeItem()
        {
            foreach (var itemEntry in currentLocation.Items)
            {

                string itemName = itemEntry.Key;

                if (dictItems.ContainsKey(itemName))
                {
                    Player.AddToInventory(dictItems[itemName]);
                    DisplayStory($"\nYou take the {itemName}.");
                }
                else
                {
                    DisplayStory("There's no item to pick up.");
                }
            }

            // Clear the items from the current location
            currentLocation.Items.Clear();

            // Update the display
            DisplayInventory();
        }
        private void HoldItem()
        {
            if (listInventory.SelectedItem != null)
            {
                // return the current item held to inventory and take new item
                Player.GetItemFromInventory(listInventory.SelectedItem.ToString());
                DisplayStory($"\nYou get the {Player.ItemInHand.Name} from your supply pack.");
                DisplayInventory();
                DisplayHand();
            }
            else
            {
                DisplayStory("\nYou have no item selected.");
            }  
        }

        private void Play()
        {
            //fill description
            DisplayStory(currentLocation.Description, true);
            NorthExit = currentLocation.LocationToNorth;
            EastExit = currentLocation.LocationToEast;
            SouthExit = currentLocation.LocationToSouth;
            WestExit = currentLocation.LocationToWest;
            DisplayInventory();
            DisplayCompass();
            DisplayHand();
        }

        private void DisplayInventory()
        {
            listInventory.Items.Clear();
            if (Player.Inventory.Count > 0)
            {
                foreach (KeyValuePair<string, Item> item in Player.Inventory)
                {
                    listInventory.Items.Add(item.Value.Name);
                }
            }
        }

        private void DisplayHand()
        {
            if (Player.ItemInHand != null)
            {
                labelHold.Text = Player.Name + " is holding: " + Player.ItemInHand.Name;
                buttonDrop.Enabled = true;
                buttonUse.Enabled = true;
            }
            else
            {
                labelHold.Text = Player.Name + " is holding: nothing";
                buttonDrop.Enabled = false;
                buttonUse.Enabled = false;
            }
        }

        private void DisplayCompass()
        {
            DisableButton(buttonUp);
            DisableButton(buttonDown);
            DisableButton(buttonLeft);
            DisableButton(buttonRight);
            if (NorthExit != "") { EnableButton(buttonUp); }
            if (EastExit != "") { EnableButton(buttonRight); }
            if (SouthExit != "") { EnableButton(buttonDown); }
            if (WestExit != "") { EnableButton(buttonLeft); }
        }
        
        private bool CheckInventory(string itemRequired)
        {
            for (int i = 0; i < Player.Inventory.Count; i++)
            {
                if (Player.Inventory.ContainsKey(itemRequired) || (Player.ItemInHand != null || Player.ItemInHand.Name == itemRequired))
                {
                    return true;
                }    
            }
            return false;
        }

        private void CheckArea(Location location)
        {
            switch(location.Name)
            {
                case "AutomatonTerminal":
                    // Die if not holding IFF
                    if (Player.ItemInHand != null && Player.ItemInHand.Name == "Automaton IFF") { Play(); break; }
                    else { PlayMusic("Music/Automaton Fight.mp3"); DisplayStory(location.BadEnding, true); break;}
                case "LabRoom":
                    // Die if Stim is not in inventory
                    if (CheckInventory("Stim") == true) {Play(); break;}
                    else {DisplayStory(location.BadEnding, true); break;}
                case "Ship":
                    // Die if Sample is not in inventory
                    if (CheckInventory("Terminid Sample") == true) { Play(); break; }
                    else { DisplayStory(location.BadEnding, true); break; }
                case "Nest": 
                    // Die if Breaker is in inventory
                    if (CheckInventory("Breaker") == false) { Play(); break; }
                    else { PlayMusic("Music/Terminid Fight.mp3"); DisplayStory(location.BadEnding, true); break; }
                case "EscapePod": 
                    // Die if Breaker is not in inventory
                    if (CheckInventory("Breaker") == true) { Play(); break; }
                    else {  DisplayStory(location.BadEnding, true); break; }
                default: Play(); break;
            }
        }
        private void CheckMusic(string locationName)
        {
            switch (locationName)
            {
                case "OutpostRoom": PlayMusic("Music/The Jail.mp3"); break;
                case "Stronghold": PlayMusic("Music/Server Queue.mp3"); break;
                
            }
        }

        private void PlayMusic(string filepath)
        {
            MXP.URL = filepath;
            MXP.settings.playCount = 9999;
            MXP.Ctlcontrols.play();
            MXP.Visible = false;
        }

        private void DisableButton(Button button)
        {
            button.Enabled = false;
        }

        private void EnableButton(Button button)
        {
            button.Enabled = true;
        }
        
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pickup_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DropClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
