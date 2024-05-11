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
using System.Reflection.Emit;

namespace SweetLiberty
{
    public partial class MainForm : Form
    {
        private Location currentLocation;
        private string NorthExit;
        private string EastExit;
        private string SouthExit;
        private string WestExit;

        private bool gameOver = false;
        private bool gameDone = false;
        
        private Dictionary<string, Location> dictLocations = new Dictionary<string, Location>();
        private Dictionary <string, Item> dictItems = new Dictionary<string, Item>();

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int timerIndex = 0;
        private string textToAdd = "";

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font FsSinclair16;
        Font FsSinclair12;
        Font FsSinclair10;

        public MainForm()
        {
            InitializeComponent();
            SetCustomFont();
            SetControlFont();
            timer.Interval = 40; // Interval in milliseconds
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
                CheckMusic(currentLocation);
                CheckArea(currentLocation);
                
                
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
                    DisplayStory($"\nI need the {exitLocation.ItemRequired.Name} to get inside the {exitLocation.DisplayName}.");
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
                EnableButton(buttonUp);
                EnableButton(buttonDown);
                EnableButton(buttonLeft);
                EnableButton(buttonRight);
                EnableButton(buttonHold);
                EnableButton(buttonPickUp);
                DisplayCompass();
                timer.Stop();
            }
        }

        private void SetControlFont()
        {
            display.Font = FsSinclair16;
            listInventory.Font = FsSinclair12;
            labelHold.Font = FsSinclair10;
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

            FsSinclair16 = new Font(fonts.Families[0], 16.0F);
            FsSinclair12 = new Font(fonts.Families[0], 12.0F);
            FsSinclair10 = new Font(fonts.Families[0], 10.0F);

        }

        private void MainFormLoad(object sender, EventArgs e){CreateGame();}
        private void ButtonUpClick(object sender, EventArgs e) { Sound.PlaySoundEffect("Sound Effects/upSound.wav"); Go("north"); }
        private void ButtonRightClick(object sender, EventArgs e) { Sound.PlaySoundEffect("Sound Effects/rightSound.wav"); Go("east"); }
        private void ButtonDownClick(object sender, EventArgs e) { Sound.PlaySoundEffect("Sound Effects/downSound.wav"); Go("south"); }
        private void ButtonLeftClick(object sender, EventArgs e) { Sound.PlaySoundEffect("Sound Effects/leftSound.wav"); Go("west"); }
        private void ButtonPickUpClick(object sender, EventArgs e) { TakeItem(); }
        private void ButtonHoldClick(object sender, EventArgs e) { HoldItem(); }
        private void ButtonDropClick(object sender, EventArgs e) { DropItem(); }
        private void ButtonUseClick(object sender, EventArgs e) { }
        private void ButtonExamineClick(object sender, EventArgs e){ ExamineItem(listInventory); }


        private void DisplayStory(string AddText, bool clear = false)
        {

            string newText = clear ? AddText : display.Text + AddText;

            SizeF textSize = TextRenderer.MeasureText(newText, display.Font, displayPanel.Size, TextFormatFlags.WordBreak);

            if (textSize.Height > (displayPanel.Height - (displayPanel.Padding.Bottom * 2.7)))
            {
                display.Text = string.Empty;
            }
            else if (clear)
            {
                display.Text = string.Empty;
            }


            textToAdd = AddText;
            timerIndex = 0;
            timer.Start();

        }

        private void CreateGame()
        {
            // Items
            dictItems.Add("Breaker", new Weapon("Breaker", "A Breaker. An automatic shotgun. Good for killing bugs and robots.", 30));
            dictItems.Add("Automaton IFF", new Item("Automaton IFF", "An Identification Friend or Foe. Automatons would see me as another one of them."));
            dictItems.Add("Terminid Sample", new Item("Terminid Sample", "A bug sample. Used to be what we came here for."));
            dictItems.Add("Stim", new FirstAid("Stim", "A Stim. Great for healing wounds. Might be useful to keep this around.", 30));

            // Logs
            dictItems.Add("Log 3AD", new Log("Log 3AD", "A log left behind by some scientists.",  "Log 3AD. The Terminid population is decreasing, but we don't know why this is happening. We need to run more tests. This cannot happen."));

            // Locations 
            AddLocations();


            Player.AddToInventory(dictItems["Breaker"]);
            Player.Name = "Alpha-Three";
            Player.Health = 100;
            Player.Strength = 50;
            currentLocation = dictLocations["Burrow"];

            CheckMusic(currentLocation);

            Play();
            
        }

        private void AddLocations()
        {
            dictLocations.Add("Prologue", new Location("Prologue",
                        "Sector 1-PL",
                        "\"Let's move it! We have no time left!\"\n" +
                        "I told you it's a bad idea to aggravate them!\n" +
                        "\"Out of my way, Three! You're just pulling us down!\"\n" +
                        "\"How about you two just focus on the mission instead of goofing around like idiots!?\"\n" +
                        "\"You know what, One? You're right. I'm calling in the Extraction Pelican!\"\n" +
                        "What about the samples!?\n" +
                        "\"Forget the samples! We need to survive!\"\n" +
                        "Alright, just keep moving forward!",
                        "Prologue2", "", "", ""));  // N E S W

            dictLocations.Add("Prologue2", new Location("Prologue2",
                        "Sector 2-AV",
                        "\"I'm calling in a Napalm Strike!\"\n" +
                        "Why did you throw it here, Four!? Are you crazy!?\n" +
                        "\"They're rushing us real hard! We can't take the pressure!\"\n" +
                        "\"We heard you, Alpha. Extraction inbound in 10 seconds.\"\n" +
                        "\"You idiot, Four! You're going to kill us all!\"\n" +
                        "\"Eagle-One coming in hot to deliver the bomb.\"\n" +
                        "\"Get out of the way! Two! No!\"\n",
                        "Prologue3", "Prologue3", "Prologue3", "Prologue3"));  // N E S W

            dictLocations.Add("Prologue3", new Location("Prologue3",
                        "Sector 2-AW",
                        "...\n....\n.....\n......\n.......\n........",
                        "Prologue4", "", "", ""));  // N E S W

            dictLocations.Add("Prologue4", new Location("Prologue4",
                        "Sector 2-AX",
                        "...\n\"Keep...\"\n.....\n\"Moving...!\"\n.......\n........",
                        "StartingArea", "", "", ""));  // N E S W

            dictLocations.Add("StartingArea", new Location("StartingArea",
                        "The Cold Wasteland",
                        "-- Log 1 --\n" +
                        "This is Squadron Alpha of the Executor of Family Values\n" +
                        ".\n.\n.\nOr what's left of it.\n" +
                        "Two of my squadmates abandoned me on the Lacaille Sector, in Lesath...\n" +
                        "And my other squadmate got caught in an Eagle Napalm Strike during extraction... He didn't make it.\n" +
                        "I just woke up. It's really cold. Blizzards everywhere. Pitch dark. Can't see anything.\n" +
                        "Automatons everywhere. Gotta hide. They must be searching for me.\n" +
                        "Saw a Stim. Probably a good idea to pick it up.",
                        "Outpost", "", "", "",  // N E S W
                        new List<Item> { dictItems["Stim"] }, null,
                        "",
                        "It's cold outside. Did I grab the Stim here?"));


            dictLocations.Add("Outpost", new Location("Outpost",
                       "Abandoned Outpost",
                       "-- Log 2 --\n" +
                       "Found an abandoned outpost. Looks like it was thrashed around.\n" +
                       "Frozen bodies everywhere. Nothing useful. Chunks of metal are rooted deep into the snow.\n" +
                       "Could get inside. Might find something. Can't tell if there's anything hiding inside.",
                       "OutpostRoom", "", "StartingArea", "Stronghold",
                       null, null,
                       "",
                       "The outpost. The frozen bodies give me a weird feeling..."));

            dictLocations.Add("OutpostRoom", new Location("OutpostRoom",
                       "Outpost Room",
                       "-- Log 3 --\n" +
                       "Went inside an abandoned outpost room. Seems it was scavenged about.\n" +
                       "Whole place is empty. Can't see anything. Save for a terminal emitting light on the far side of the room.\n" +
                       "Probably something useful there-- Sweet Liberty!\n" +
                       "Ah, it's just a rat. I could use a LiberTea right now...",
                       "OutpostTerminal", "", "Outpost", "",
                       null, null,
                       "",
                       "Can't believe I got shocked by some democratic rat..."));

            dictLocations.Add("OutpostTerminal", new Location("OutpostTerminal",
                       "Outpost Terminal",
                       "-- Log 4 -- \n" +
                       "Went to the terminal. It might be on, but any touch on it doesn't make it respond.\n" +
                       "Found a Breaker underneath the terminal. A fully loaded automatic shotgun. Might be useful to pick up.",
                       "", "", "OutpostRoom", "",
                       new List<Item> { dictItems["Breaker"] }, null,
                       "",
                       "The terminal... that doesn't even work. Did I grab the Breaker here?"));

            dictLocations.Add("Stronghold", new Location("Stronghold",
                       "Automaton Stronghold",
                       "-- Log 5 --\n" +
                       "Found what appears to be an Automaton Stronghold. Multiple of them in visual. Need to scope the area out.\n" +
                       "Scaled up to get a bit closer. Needed a better view of the stronghold.\n" +
                       "The base is so massive. There may be something useful there, but how am I gonna get in?\n" +
                       "Ah crap, there's an automaton squadron nearby. I need to lay low.\n" +
                       "Crap! Enemy tango might have spotted me. Eyes glowed bright red. Should be fine. I ducked behind a rock for cover.\n" +
                       "This place is extremely dangerous. Need to consider if I should enter now.",
                       "AutomatonTerminal", "Outpost", "", "CrashSite",
                       null, null,
                       "",
                       "The Automaton Stronghold. There's a lot of them..."));

            dictLocations.Add("AutomatonTerminal", new Location("AutomatonTerminal",
                       "Automaton Terminal",
                       "-- Log 9 -- \n" +
                       "There's a lot of them here... Lined up like soldiers. Good thing I'm not seen as a foe.\n" +
                       "Nearing the end of this hallway... Huh...\n" +
                       "Looks like an Automaton control center for the ship deployments. There's a terminal in the center.\n" +
                       "I just need to do this little button combination... and...\n" +
                       "There. I'm leaving. I'm finally going home.",
                       "Ship", "", "Prologue", "",
                       null, null,
                       "Decided to approach the terminal. It's a big risk, but I'll have to take it.\n" +
                       "They spotted me! I'm taking fire! I might not be able to hold on!\n" +
                       "Sweet Liberty! A grenade!\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1...\n" +
                       "DONE. PLEASE CLICK THE DOWN BUTTON TO CONTINUE."));

            dictLocations.Add("Ship", new Location("Ship",
                       "Destroyer Ship",
                       "-- Log 13 --\n" +
                       "Delivered the sample to the higher ups. They seemed really happy about my performance.\n" +
                       "I also heard the two squadmates that left us were executed for being traitors.\n" +
                       "Seems right now I'm just assigned to paperwork as a promotion.\n" +
                       "Might not be so bad after all...\n" +
                       "Sweet Liberty...\n" +
                       "GOOD ENDING ACHIEVED. YOU'VE GIVEN HUMANITY A CHANCE. GLORY TO SUPER EARTH.\n" +
                       "PRESS THE DOWN BUTTON TO TRY AGAIN.",
                       "Prologue", "", "Prologue", "", //N E S W
                       null, null, // items and itemRequired
                       "...I am deemed as a traitor.\n" +
                       "They still asked me for the Terminid sample. The reason why they sent us there in the first place.\n" +
                       "I wasn't able to retrieve it.\n" +
                       "YOU HAVE BEEN MARKED AS A TRAITOR. PLEASE STAND STILL IN THE DESIGNATED AREA.\n" +
                       "LAUNCHING 120MM HE BARRAGE IN 3... 2... 1...\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1...\n" +
                       "DONE. PLEASE CLICK THE UP BUTTON TO CONTINUE."));

            dictLocations.Add("CrashSite", new Location("CrashSite",
                       "Crash Site",
                       "-- Log 6 --\n" +
                       "Found an escape pod. It crashed deep into the snow.\n" +
                       "An automaton's guarding it. Looks like a suicide bomber.\n" +
                       "Might be advisable to hold a weapon before going in.\n",
                       "EscapePod", "Stronghold", "", "",
                       null, null,
                       "",
                       "The escape pod's crash site. Thing really took a big hit."));

            dictLocations.Add("EscapePod", new Location("EscapePod",
                       "Escape Pod",
                       "-- Log 7 --\n" +
                       "Killed the automaton easily. Tried to open the pod. Doesn't budge.\n" +
                       "Dug out some snow. Found what seems to be an Automaton IFF.\n" +
                       "Could help me get through some Automaton patrols.\n" +
                       "They'll see me and they'll think I'm a friendly.\n" +
                       "Would be helpful to pick it up and hold it on the way.",
                       "", "", "CrashSite", "Burrow",
                       new List<Item> { dictItems["Automaton IFF"] },
                       null,
                       "-- Log 6 --\n" +
                       "I've decided to face the--\n" +
                       "Close-range explosion detected.\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1...",
                       "The escape pod. That suicide bomber automaton was a pain in the ass..."));

            dictLocations.Add("Burrow", new Location("Burrow",
                       "Terminid Burrow",
                       "-- Log 10 --\n" +
                       "I found this small opening... Looks like it was burrowed through.\n" +
                       "I'm not entirely sure what's inside... Should I check it out?",
                       "Nest", "EscapePod", "", "LabOutpost",
                       null, null,
                       "",
                       "A small burrow... Might be some Terminids in there..."));

            dictLocations.Add("Nest", new Location("Nest",
                       "Terminid Nest",
                       "-- Log 11 --\n" +
                       "Log 8. I crawled through this opening... Looks like it was burrowed through.\n" +
                       "Wait... is that a...\n" +
                       "It's a Bile Spewer... But it doesn't seem to be attacking.\n" +
                       "Maybe it doesn't mean any harm?",
                       "TimeSkip", "", "Prologue", "",
                       null, null,
                       "-- Log 8 --\n" +
                       "I crawled through this opening... And I hear a lot of slitehring sounds...\n" +
                       "Wait... is that a...\n" +
                       "It's a Bile Spewer! Agghhh!\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1...\n" +
                       "DONE. PLEASE CLICK THE DOWN BUTTON TO CONTINUE."));

            dictLocations.Add("TimeSkip", new Location("TimeSkip",
                       "Time Skip",
                       "-- Log 29 --\n" +
                       "It's almost been a month, but I got used to life here in Lesath.\n" +
                       "These Terminids that I found seem to see me as their leader...\n" +
                       "They also reproduced so fast that they've taken over the underground area of this planet...\n" +
                       "Maybe living like this... Isn't so bad after all...\n" +
                       "\n\n\nGOOD ENDING ACHIEVED. GLORY TO SUPER EARTH. THOUGH YOU MAY BE BRANDED A TRAITOR."));

            dictLocations.Add("LabOutpost", new Location("LabOutpost",
                       "Laboratory Outpost",
                       "-- Log 12 --\n" +
                       "Noticed an outpost in the distance.\n" +
                       "Looks like a lab of sorts... Looks like it was sealed from the inside.\n" +
                       "I hear something inside. There's something there.\n" +
                       "Can't get in there without using a gun on it.\n",
                       "LabRoom", "Burrow", "", "",
                       null, null,
                       "",
                       "The lab outpost. Seemed to be a laboratory for studying Terminids."));

            dictLocations.Add("LabRoom", new Location("LabRoom",
                       "Laboratory Room",
                       "-- Log 13 --\n" +
                       "The door seems to have be smashed down...\n" +
                       "Movement's getting louder... Where is it coming from?\n" +
                       "GAH! Terminid!\n" +
                       "I killed it... But...\n" +
                       "I'm bleeding out...\n" +
                       "Good thing I have this stim. WOOH! Sweet Liberty...\n" +
                       "This lab... Looks like they were experimenting on the Terminids.\n" +
                       "That might be the sample we're looking for on that table... \n" +
                       "Should pick it up. A log's next to it.",
                       "Prologue", "", "LabOutpost", "",
                       new List<Item> { dictItems["Log 3AD"], dictItems["Terminid Sample"] }, dictItems["Breaker"],
                       "-- Log 13 --\n" +
                       "The door seems to have be smashed down...\n" +
                       "Movement's getting louder... Where is it coming from?\n" +
                       "GAH! Terminid!\n" +
                       "I killed it... But...\n" +
                       "I'm bleeding out...\n" +
                       "Sweet Liberty, I got nothing!\n" +
                       "About... to... pass... out...\n" +
                       "UNEXPECTED LOG TERMINATION.\n" +
                       "FINISHING TERMINATION IN 3... 2... 1...\n" +
                       "DONE. PLEASE CLICK THE UP BUTTON TO CONTINUE.",
                       "The lab room. Found the sample here. Did I take it?"));
        }

        private void ResetGame()
        {
            Player.Inventory.Clear();
            Player.ItemInHand = null;
            dictLocations.Clear();
            AddLocations();
            gameOver = false;
            currentLocation = dictLocations["Prologue"];
        }

        private void TakeItem()
        {

            if (currentLocation.Items.Count == 0)
            {
                DisplayStory("\nThere's nothing to pick up.");
            }

            else
            {
                foreach (var itemEntry in currentLocation.Items)
                {
                    string itemName = itemEntry.Key;

                    if (dictItems.ContainsKey(itemName))
                    {
                        Sound.PlaySoundEffect("Sound Effects/pick up.wav");
                        Player.AddToInventory(dictItems[itemName]);
                        DisplayStory($"\nI took the {itemName}.");
                    }
                }

                // Clear the items from the current location
                currentLocation.Items.Clear();
            }

            // Update the display
            DisplayInventory();
        }
        private void ExamineItem(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                Item item = dictItems[comboBox.SelectedItem.ToString()]; // find the item by name
                DisplayStory("\n" + item.Description);
            }
            else
            {
                DisplayStory("\nThere's nothing to examine.");
            }
            
        }

        private void DropItem()
        {
            DisplayStory($"\nI dropped the {Player.ItemInHand.Name}.\nI can pick it up again here if I ever need it.");
            currentLocation.AddItem(Player.ItemInHand);
            Player.ItemInHand = null;
            DisplayHand();
        }
        
        private void HoldItem()
        {
            if (listInventory.SelectedItem != null && Player.ItemInHand == null)
            {
                // return the current item held to inventory and take new item
                Player.GetItemFromInventory(listInventory.SelectedItem.ToString());
                DisplayStory($"\nI took the {Player.ItemInHand.Name} from my supply pack.");
                DisplayInventory();
                DisplayHand();
            }
            else if (listInventory.SelectedItem == null && Player.ItemInHand != null)
            {
                DisplayStory($"\nI returned the {Player.ItemInHand.Name} to my supply pack.");
                Player.ReturnItemToInventory();
                DisplayInventory();
                DisplayHand();
            }
            else if (listInventory.SelectedItem != null && Player.ItemInHand != null)
            {
                DisplayStory($"\nI returned the {Player.ItemInHand.Name} to my supply pack.");
                Player.ReturnItemToInventory();
                Player.GetItemFromInventory(listInventory.SelectedItem.ToString());
                DisplayStory($"\nI took the {Player.ItemInHand.Name} from my supply pack.");
                DisplayInventory();
                DisplayHand();
            }
            else
            {
                DisplayStory("\nGot nothing to hold.");
            }  
        }

        private void Play()
        {
            //fill description

            if (gameOver == true)
            {
                DisplayStory(currentLocation.BadEnding, true);
            }

            else if (currentLocation.Entered == false)
            {
                currentLocation.Entered = true;
                DisplayStory(currentLocation.Description, true);
            }
            else
            {
                DisplayStory(currentLocation.Backtrack, true);
            }
            
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
            if ((NorthExit != "Prologue" && NorthExit != ""  && gameOver == false) || (NorthExit == "Prologue" && gameOver == true) || (NorthExit == "Prologue" && gameDone == true)) { EnableButton(buttonUp); }
            if (EastExit != "") { EnableButton(buttonRight); }
            if ((SouthExit != "Prologue" && SouthExit != "" && gameOver == false) || (SouthExit == "Prologue" && gameOver == true) || (SouthExit == "Prologue" && gameDone == true)) { EnableButton(buttonDown); }
            if (WestExit != "") { EnableButton(buttonLeft); }
        }
        
        private bool CheckInventory(string itemRequired)
        {
            for (int i = 0; i < Player.Inventory.Count; i++)
            {
                if (Player.Inventory.ContainsKey(itemRequired) || (Player.ItemInHand != null && Player.ItemInHand.Name == itemRequired))
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
                case "Prologue":
                    if (gameOver == true || gameDone == true) 
                    {
                        ResetGame();
                        Play();
                    }
                    break;
                case "AutomatonTerminal":
                    // Die if not holding IFF
                    if (Player.ItemInHand != null && Player.ItemInHand.Name == "Automaton IFF") { Play(); break; }
                    else { PlayMusic("Music/Automaton Fight.mp3"); Sound.PlaySoundEffect("Sound Effects/outpost death.wav"); gameOver = true; Play(); break;}
                case "LabRoom":
                    // Die if Stim is not in inventory
                    if (CheckInventory("Stim") == true) {Play(); break;}
                    else { Sound.PlaySoundEffect("Music Effects/ labroom-terminid2.wav"); gameOver = true; Play(); break;}
                case "Ship":
                    // Die if Sample is not in inventory
                    if (CheckInventory("Terminid Sample") == true) { Play(); break; }
                    else { gameOver = true; Play(); break; }
                case "Nest": 
                    // Die if Breaker is in inventory
                    if (CheckInventory("Breaker") == false) { Play(); break; }
                    else { PlayMusic("Music/Terminid Fight.mp3"); Sound.PlaySoundEffect("Sound Effects/bilespewer.wav");  gameOver = true; Play(); break; }
                case "EscapePod": 
                    // Die if Breaker is not in inventory
                    if (CheckInventory("Breaker") == true) { Play(); break; }
                    else { MXP.Ctlcontrols.stop(); Sound.PlaySoundEffect("Sound Effects/explosion2.wav"); gameOver = true; Play(); break; }
                default: Play(); break;
            }
        }
        private void CheckMusic(Location location)
        {
            switch (location.Name)
            {
                case "Prologue": PlayMusic("Music/Extraction.mp3"); break;
                case "Prologue2": Sound.PlaySoundEffect("Sound Effects/Priming.wav"); break;
                case "Prologue3": MXP.Ctlcontrols.stop(); Sound.PlaySoundEffect("Sound Effects/Explosion.wav"); break;
                case "Prologue4": Sound.PlaySoundEffect("Sound Effects/haze.wav"); break;
                case "StartingArea": PlayMusic("Music/Long Night of Solace.mp3"); Sound.PlaySoundEffect("Sound Effects/blizzard.wav"); break;
                case "Outpost": Sound.PlaySoundEffect("Sound Effects/blizzard.wav"); break;
                case "LabRoom": if (currentLocation.Entered == false) { MXP.Ctlcontrols.stop(); Sound.PlaySoundEffect("Sound Effects/labroom-terminid.wav"); } else { MXP.Ctlcontrols.stop(); Sound.PlaySoundEffect("Sound Effects/labroom.wav"); }  break;
                case "OutpostRoom": if (currentLocation.Entered == false) { PlayMusic("Music/The Jail.mp3"); Sound.PlaySoundEffect("Sound Effects/a rat.wav"); } break;
                case "Stronghold": if (currentLocation.Entered == false) { PlayMusic("Music/Server Queue.mp3"); Sound.PlaySoundEffect("Sound Effects/spotted.wav"); } break;
                case "EscapePod": if (currentLocation.Entered == false) { Sound.PlaySoundEffect("Sound Effects/automaton killed.wav"); } break; 
                case "AutomatonTerminal": PlayMusic("Music/Extraction.mp3"); Sound.PlaySoundEffect("Sound Effects/button combination.wav"); break;
                case "Nest": gameDone = true; PlayMusic("Music/Cars.mp3"); break;
                case "Ship": gameDone = true; PlayMusic("Music/Cars.mp3"); break;
                default:break;
            }
        }

        private void PlayMusic(string filepath)
        {
            MXP.URL = filepath;
            MXP.settings.playCount = 9999;
            MXP.settings.volume = 35;
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

        private void buttonUp_MouseDown(object sender, MouseEventArgs e)
        {
            buttonUp.BackgroundImage = Properties.Resources.buttonUpPress;
        }

        private void buttonUp_MouseUp(object sender, MouseEventArgs e)
        {
            buttonUp.BackgroundImage = Properties.Resources.buttonUpDefault;
        }

        private void buttonDown_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDown.BackgroundImage = Properties.Resources.buttonDownPress;
        }

        private void buttonDown_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDown.BackgroundImage = Properties.Resources.buttonDownDefault;
        }

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLeft.BackgroundImage = Properties.Resources.buttonLeftPress;
        }

        private void buttonLeft_MouseUp(object sender, MouseEventArgs e)
        {
            buttonLeft.BackgroundImage = Properties.Resources.buttonLeftDefault;
        }

        private void buttonRight_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRight.BackgroundImage = Properties.Resources.buttonRightPress;
        }

        private void buttonRight_MouseUp(object sender, MouseEventArgs e)
        {
            buttonRight.BackgroundImage = Properties.Resources.buttonRightDefault;
        }

        private void buttonDrop_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDrop.BackgroundImage = Properties.Resources.buttonDropPress;
        }

        private void buttonDrop_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDrop.BackgroundImage = Properties.Resources.buttonDropDefault;    
        }

        private void buttonDrop_MouseDown_1(object sender, MouseEventArgs e)
        {
            buttonDrop.BackgroundImage = Properties.Resources.buttonDropPress;
        }

        private void buttonDrop_MouseUp_1(object sender, MouseEventArgs e)
        {
            buttonDrop.BackgroundImage = Properties.Resources.buttonDropDefault;
        }

        private void buttonExamine_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExamine.BackgroundImage = Properties.Resources.buttonExaminePress;
        }

        private void buttonExamine_MouseUp(object sender, MouseEventArgs e)
        {
            buttonExamine.BackgroundImage = Properties.Resources.buttonExamineDefault;
        }

        private void buttonUse_MouseDown(object sender, MouseEventArgs e)
        {
            buttonUse.BackgroundImage = Properties.Resources.buttonUsePress;
        }

        private void buttonUse_MouseUp(object sender, MouseEventArgs e)
        {
            buttonUse.BackgroundImage = Properties.Resources.buttonUseDefault;
        }

        private void buttonHold_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHold.BackgroundImage = Properties.Resources.buttonHoldPress;
        }

        private void buttonHold_MouseUp(object sender, MouseEventArgs e)
        {
            buttonHold.BackgroundImage = Properties.Resources.buttonHoldDefault;
        }

        private void buttonPickUp_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPickUp.BackgroundImage = Properties.Resources.buttonPickupPress;
        }

        private void buttonPickUp_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPickUp.BackgroundImage = Properties.Resources.buttonPickupDefault;
        }

    }
}
