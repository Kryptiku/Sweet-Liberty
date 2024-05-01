namespace Initial_UI_Design
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control1 = new System.Windows.Forms.Control();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.display = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listInventory = new System.Windows.Forms.ComboBox();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pickup_lbl = new System.Windows.Forms.Label();
            this.pickup_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 38);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.flowLayoutPanel2.Controls.Add(this.btn_close);
            this.flowLayoutPanel2.Controls.Add(this.btn_minimize);
            this.flowLayoutPanel2.Controls.Add(this.btn_maximize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1263, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(123, 36);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_close.Location = new System.Drawing.Point(95, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 33);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_minimize.Location = new System.Drawing.Point(64, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 33);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.BackgroundImage")));
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_maximize.Location = new System.Drawing.Point(33, 3);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(25, 33);
            this.btn_maximize.TabIndex = 5;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 36);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::Initial_UI_Design.Properties.Resources.Screenshot_2024_04_29_003510;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 29);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(464, 173);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(188, 58);
            this.control1.TabIndex = 1;
            this.control1.Text = "control1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("FS Sinclair Trial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(127)))));
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.listInventory);
            this.splitContainer1.Panel2.Controls.Add(this.MXP);
            this.splitContainer1.Panel2.Controls.Add(this.pickup_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.pickup_btn);
            this.splitContainer1.Panel2.Controls.Add(this.inventory_btn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRight);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLeft);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDown);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUp);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1388, 620);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.display);
            this.panel3.Location = new System.Drawing.Point(23, 17);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(16, 20, 6, 6);
            this.panel3.Size = new System.Drawing.Size(1330, 390);
            this.panel3.TabIndex = 0;
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Location = new System.Drawing.Point(16, 23);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 35);
            this.display.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(191, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "Use";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(58, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Drop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listInventory
            // 
            this.listInventory.FormattingEnabled = true;
            this.listInventory.Location = new System.Drawing.Point(58, 65);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(243, 20);
            this.listInventory.TabIndex = 11;
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(879, 119);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(411, 56);
            this.MXP.TabIndex = 10;
            this.MXP.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pickup_lbl
            // 
            this.pickup_lbl.AutoSize = true;
            this.pickup_lbl.Font = new System.Drawing.Font("Artemus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickup_lbl.Location = new System.Drawing.Point(1245, 68);
            this.pickup_lbl.Name = "pickup_lbl";
            this.pickup_lbl.Size = new System.Drawing.Size(64, 12);
            this.pickup_lbl.TabIndex = 9;
            this.pickup_lbl.Text = "Pickup";
            this.pickup_lbl.Click += new System.EventHandler(this.pickup_lbl_Click);
            // 
            // pickup_btn
            // 
            this.pickup_btn.BackgroundImage = global::Initial_UI_Design.Properties.Resources.pickup_btn;
            this.pickup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pickup_btn.FlatAppearance.BorderSize = 0;
            this.pickup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickup_btn.Location = new System.Drawing.Point(1258, 18);
            this.pickup_btn.Name = "pickup_btn";
            this.pickup_btn.Size = new System.Drawing.Size(32, 47);
            this.pickup_btn.TabIndex = 6;
            this.pickup_btn.UseVisualStyleBackColor = true;
            this.pickup_btn.Click += new System.EventHandler(this.pickup_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackgroundImage = global::Initial_UI_Design.Properties.Resources.inventory_btn;
            this.inventory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Location = new System.Drawing.Point(160, 27);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(38, 35);
            this.inventory_btn.TabIndex = 4;
            this.inventory_btn.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::Initial_UI_Design.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(760, 51);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(78, 67);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::Initial_UI_Design.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(673, 51);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(81, 64);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::Initial_UI_Design.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Location = new System.Drawing.Point(602, 51);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(65, 69);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonDownClick);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::Initial_UI_Design.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.ForeColor = System.Drawing.Color.Gold;
            this.buttonUp.Location = new System.Drawing.Point(532, 42);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(64, 84);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonUpClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 620);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Initial_UI_Design.Properties.Resources.bottom_navigation_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(486, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 59);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1388, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Artemus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sweet Liberty ";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label pickup_lbl;
        private System.Windows.Forms.Button pickup_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox listInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label display;
    }
}

