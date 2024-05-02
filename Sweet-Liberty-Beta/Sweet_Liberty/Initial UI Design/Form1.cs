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

namespace Initial_UI_Design
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 30; // Interval in milliseconds
            timer.Tick += Timer_Tick;
        }

        private void Go(string Direction)
        {
            //has to be an exit here else button would not be enabled
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
                Play();
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timerIndex < textToAdd.Length)
            {
                display.Text += textToAdd[timerIndex];
                timerIndex++;
            }
            else
            {
                timer.Stop(); // Stop the timer when the entire string has been displayed
            }
        }

        private void SetCustomFont(string filepath, int size)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile(filepath);
            foreach (Control c in this.Controls)
            {

                c.Font = new Font(fontCollection.Families[0], size, FontStyle.Regular);
            }
        }

        private void MainFormLoad(object sender, EventArgs e){CreateGame();}
        private void ButtonUpClick(object sender, EventArgs e) { Sound.PlaySoundEffect("upSound.wav"); Go("north"); }
        private void ButtonRightClick(object sender, EventArgs e) { Sound.PlaySoundEffect("rightSound.wav"); Go("east"); }
        private void ButtonDownClick(object sender, EventArgs e) { Sound.PlaySoundEffect("downSound.wav"); Go("south"); }
        private void ButtonLeftClick(object sender, EventArgs e) { Sound.PlaySoundEffect("leftSound.wav"); Go("west"); }


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
            SetCustomFont("Resources/FSSinclairTrial-Bold.otf", 16);

            PlayMusic("Long Night of Solace.wav");
            Sound.PlaySoundEffect("terminal.wav");

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
                        "Log 1 of Squadron Alpha of the Executor of Family Values... or what's left of it.\n" +
                        "Two of my squadmates abandoned me on Lacaille Sector, in Lesath...\n" +
                        "and my other squadmate got caught in an Eagle Napalm Strike during extraction... He didn't make it.\n" +
                        "It's really cold. Blizzards everywhere. Pitch dark. Can't see shit.\n" +
                        "Automatons everywhere. Gotta hide. They must be searching for me.\n" +
                        "Saw a Stim. Probably a good idea to pick it up.",
                        "Outpost", "", "", "",  // N E S W
                         new List<Item> { dictItems["Stim"] }));

            dictLocations.Add("Outpost", new Location("Outpost",
                       "Abandoned Outpost",
                       "Log 2. Found an abandoned outpost. Looks like it was thrashed around.\n" +
                       "Frozen bodies everywhere. Nothing useful. Chunks of metal are rooted deep into the snow.\n" +
                       "Could get inside. Might find something. Can't tell if there's anything hiding inside.",
                       "OutpostRoom", "", "StartingArea", "Stronghold"));

            dictLocations.Add("OutpostRoom", new Location("OutpostRoom",
                       "Outpost Room",
                       "Log 3. Went inside an abandoned outpost room. Seems it was scavenged about.\n" +
                       "Whole place is empty. Can't see anything. Save for a terminal emitting light on the far side of the room.\n" +
                       "Probably something useful there-- shit!\n" +
                       "Ah, it's just a rat. Fuck.", 
                       "OutpostTerminal", "", "Outpost", ""));

            dictLocations.Add("OutpostTerminal", new Location("OutpostTerminal",
                       "Outpost Terminal",
                       "Log 4. Went to the terminal. It might be on, but any touch on it doesn't make it respond.\n" +
                       "Found a Breaker underneath the terminal. A fully loaded automatic shotgun. Might be useful to pick up.",
                       "", "", "OutpostRoom", "",
                       new List<Item> { dictItems["Breaker"] }));






            Player.Name = "Alpha-Three";
            Player.Health = 100;
            Player.Strength = 50;
            currentLocation = dictLocations["StartingArea"];

            Play();
            
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
            // DisplayHand();
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
        private void DisableButton(Button button)
        {
            button.Enabled = false;
            button.ForeColor = Color.Gainsboro;
        }

        private void EnableButton(Button button)
        {
            button.Enabled = true;
            button.ForeColor = Color.Yellow;
        }

  

        private void PlayMusic(string filepath)
        {
            MXP.URL = filepath;
            MXP.settings.playCount = 9999;
            MXP.Ctlcontrols.play();
            MXP.Visible = false;
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

        private void pickup_btn_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void display_Paint(object sender, PaintEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DropClick(object sender, EventArgs e)
        {

        }
    }
}
