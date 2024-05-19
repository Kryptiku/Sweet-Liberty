using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace SweetLiberty
{
    public partial class LandingPage : Form
    {
        private IUserService userService;

        public LandingPage()
        {
            InitializeComponent();
            string filePath = "UserData.CSV"; 
            IUserDataService userDataService = new CsvFileDataService(filePath);
            userService = new UserService(userDataService);
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (userService.SignUp(username, password))
            {
                MessageBox.Show("User signed up successfully!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (userService.Login(username, password))
            {
                MessageBox.Show("Login successful!");
                textBox1.Clear();
                textBox2.Clear();

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            login.BackgroundImage = Properties.Resources.buttonLoginDefault;
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            login.BackgroundImage = Properties.Resources.buttonLoginPress;
            login.BackgroundImage = Properties.Resources.buttonLoginDefault;
        }

        private void signup_MouseDown(object sender, MouseEventArgs e)
        {
            signup.BackgroundImage = Properties.Resources.buttonSignupDefault;
        }

        private void signup_MouseUp(object sender, MouseEventArgs e)
        {
            signup.BackgroundImage = Properties.Resources.buttonSignupPress;
            signup.BackgroundImage = Properties.Resources.buttonSignupDefault;
        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.buttonJustPlayDefault;
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.buttonJustPlayPress;
            playButton.BackgroundImage = Properties.Resources.buttonJustPlayDefault;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public interface IUserService
    {
        bool Login(string username, string password);
        bool SignUp(string username, string password);
    }

    public interface IUserDataService
    {
        List<User> GetAllUsers();
        void SaveUser(User user);
    }

    public class UserService : IUserService
    {
        private IUserDataService userDataService;

        public UserService(IUserDataService userDataService)
        {
            this.userDataService = userDataService;
        }

        public bool Login(string username, string password)
        {
            var users = userDataService.GetAllUsers();
            return users.Any(u => u.Username == username && u.Password == password);
        }

        public bool SignUp(string username, string password)
        {
            var users = userDataService.GetAllUsers();
            if (users.Any(u => u.Username == username))
            {
                return false;
            }

            userDataService.SaveUser(new User { Username = username, Password = password });
            return true;
        }
    }

    public class CsvFileDataService : IUserDataService
    {
        private string filePath;

        public CsvFileDataService(string filePath)
        {
            this.filePath = filePath;
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        users.Add(new User { Username = parts[0], Password = parts[1] });
                    }
                }
            }
            return users;
        }

        public void SaveUser(User user)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{user.Username},{user.Password}");
            }
        }
    }
}
