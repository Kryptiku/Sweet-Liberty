namespace SweetLiberty
{
    partial class LandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_text = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title_text);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 42);
            this.panel1.TabIndex = 0;
            // 
            // title_text
            // 
            this.title_text.AutoSize = true;
            this.title_text.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(80)))));
            this.title_text.Location = new System.Drawing.Point(8, 11);
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(124, 19);
            this.title_text.TabIndex = 1;
            this.title_text.Text = "Sweet Liberty";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_close.Location = new System.Drawing.Point(770, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 33);
            this.btn_close.TabIndex = 8;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_minimize.Location = new System.Drawing.Point(739, 5);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 33);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 22);
            this.textBox2.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(139, 117);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 16);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(139, 173);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 16);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Location = new System.Drawing.Point(293, 226);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 28);
            this.login.TabIndex = 5;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // signup
            // 
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Location = new System.Drawing.Point(413, 226);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 28);
            this.signup.TabIndex = 6;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // playButton
            // 
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(347, 288);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(90, 38);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Just Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(807, 365);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LandingPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label title_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button playButton;
    }
}