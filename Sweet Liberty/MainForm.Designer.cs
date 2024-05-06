namespace SweetLiberty
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control1 = new System.Windows.Forms.Control();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.display = new System.Windows.Forms.Label();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.labelHold = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.listInventory = new System.Windows.Forms.ComboBox();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonHold = new System.Windows.Forms.Button();
            this.buttonPickUp = new System.Windows.Forms.Button();
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
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 38);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.flowLayoutPanel2.Controls.Add(this.btn_close);
            this.flowLayoutPanel2.Controls.Add(this.btn_minimize);
            this.flowLayoutPanel2.Controls.Add(this.btn_maximize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1245, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(123, 36);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            this.btn_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 36);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::SweetLiberty.Properties.Resources.Screenshot_2024_04_29_003510;
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.displayPanel);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(127)))));
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 30, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.splitContainer1.Panel2.Controls.Add(this.buttonExamine);
            this.splitContainer1.Panel2.Controls.Add(this.labelHold);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUse);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDrop);
            this.splitContainer1.Panel2.Controls.Add(this.listInventory);
            this.splitContainer1.Panel2.Controls.Add(this.MXP);
            this.splitContainer1.Panel2.Controls.Add(this.buttonHold);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPickUp);
            this.splitContainer1.Panel2.Controls.Add(this.inventory_btn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRight);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLeft);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDown);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUp);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 620);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 2;
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(18)))));
            this.displayPanel.Controls.Add(this.display);
            this.displayPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPanel.Location = new System.Drawing.Point(26, 17);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Padding = new System.Windows.Forms.Padding(16, 20, 6, 6);
            this.displayPanel.Size = new System.Drawing.Size(1319, 390);
            this.displayPanel.TabIndex = 0;
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Location = new System.Drawing.Point(16, 23);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 32);
            this.display.TabIndex = 0;
            // 
            // buttonExamine
            // 
            this.buttonExamine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonExamine.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonExamineDefault;
            this.buttonExamine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExamine.FlatAppearance.BorderSize = 0;
            this.buttonExamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExamine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.buttonExamine.Location = new System.Drawing.Point(641, 95);
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.Size = new System.Drawing.Size(75, 75);
            this.buttonExamine.TabIndex = 16;
            this.buttonExamine.UseVisualStyleBackColor = false;
            this.buttonExamine.Click += new System.EventHandler(this.ButtonExamineClick);
            this.buttonExamine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExamine_MouseDown);
            this.buttonExamine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonExamine_MouseUp);
            // 
            // labelHold
            // 
            this.labelHold.AutoSize = true;
            this.labelHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHold.Location = new System.Drawing.Point(129, 55);
            this.labelHold.Name = "labelHold";
            this.labelHold.Size = new System.Drawing.Size(0, 16);
            this.labelHold.TabIndex = 15;
            // 
            // buttonUse
            // 
            this.buttonUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonUse.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonUseDefault;
            this.buttonUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUse.FlatAppearance.BorderSize = 0;
            this.buttonUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.buttonUse.Location = new System.Drawing.Point(678, 20);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(75, 75);
            this.buttonUse.TabIndex = 13;
            this.buttonUse.UseVisualStyleBackColor = false;
            this.buttonUse.Click += new System.EventHandler(this.ButtonUseClick);
            this.buttonUse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUse_MouseDown);
            this.buttonUse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUse_MouseUp);
            // 
            // buttonDrop
            // 
            this.buttonDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonDrop.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonDropDefault;
            this.buttonDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDrop.FlatAppearance.BorderSize = 0;
            this.buttonDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.buttonDrop.Location = new System.Drawing.Point(604, 20);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(75, 75);
            this.buttonDrop.TabIndex = 12;
            this.buttonDrop.UseVisualStyleBackColor = false;
            this.buttonDrop.Click += new System.EventHandler(this.ButtonDropClick);
            this.buttonDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDrop_MouseDown_1);
            this.buttonDrop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDrop_MouseUp_1);
            // 
            // listInventory
            // 
            this.listInventory.FormattingEnabled = true;
            this.listInventory.Location = new System.Drawing.Point(132, 28);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(226, 24);
            this.listInventory.TabIndex = 11;
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(71, 114);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(411, 56);
            this.MXP.TabIndex = 10;
            // 
            // buttonHold
            // 
            this.buttonHold.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonHoldDefault;
            this.buttonHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHold.FlatAppearance.BorderSize = 0;
            this.buttonHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHold.Location = new System.Drawing.Point(753, 20);
            this.buttonHold.Name = "buttonHold";
            this.buttonHold.Size = new System.Drawing.Size(75, 75);
            this.buttonHold.TabIndex = 6;
            this.buttonHold.UseVisualStyleBackColor = true;
            this.buttonHold.Click += new System.EventHandler(this.ButtonHoldClick);
            this.buttonHold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHold_MouseDown);
            this.buttonHold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonHold_MouseUp);
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonPickupDefault;
            this.buttonPickUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPickUp.FlatAppearance.BorderSize = 0;
            this.buttonPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickUp.Location = new System.Drawing.Point(715, 95);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(75, 75);
            this.buttonPickUp.TabIndex = 6;
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.ButtonPickUpClick);
            this.buttonPickUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPickUp_MouseDown);
            this.buttonPickUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPickUp_MouseUp);
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackgroundImage = global::SweetLiberty.Properties.Resources.inventory_btn;
            this.inventory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Location = new System.Drawing.Point(80, 20);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(38, 35);
            this.inventory_btn.TabIndex = 4;
            this.inventory_btn.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRight.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonRightDefault;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(1182, 95);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 75);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
            this.buttonRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseDown);
            this.buttonRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseUp);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonLeftDefault;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(1032, 95);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 75);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
            this.buttonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseUp);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonDownDefault;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Location = new System.Drawing.Point(1107, 95);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 75);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonDownClick);
            this.buttonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseDown);
            this.buttonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseUp);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::SweetLiberty.Properties.Resources.buttonUpDefault;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(127)))));
            this.buttonUp.Location = new System.Drawing.Point(1107, 20);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 75);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonUpClick);
            this.buttonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseDown);
            this.buttonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 620);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SweetLiberty.Properties.Resources.bottom_navigation_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(486, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 59);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::SweetLiberty.Properties.Resources.Sweet_Liberty;
            this.Name = "MainForm";
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
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
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
        private System.Windows.Forms.Button buttonPickUp;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.ComboBox listInventory;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button buttonHold;
        private System.Windows.Forms.Label labelHold;
        private System.Windows.Forms.Button buttonExamine;
    }
}

