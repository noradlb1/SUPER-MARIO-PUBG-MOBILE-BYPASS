using System;
using System.Net;
using System.Windows.Forms;
namespace numer
{
    partial class BP
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.photo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.malki = new Guna.UI2.WinForms.Guna2TextBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.addTextWithAnimation = new System.Windows.Forms.Timer(this.components);
            this.animatedText = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.guna2ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.EX = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ContextMenuStrip3 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.tttmer = new Guna.UI2.WinForms.Guna2TextBox();
            this.chackgameloop = new System.Windows.Forms.Timer(this.components);
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.crack = new System.Windows.Forms.Timer(this.components);
            this.program = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.khaledmalki = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.check = new System.Windows.Forms.Timer(this.components);
            this.pubgm = new System.Windows.Forms.Timer(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.startCirclePnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.titleLbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.subtitleLbl = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chechiking = new System.Windows.Forms.Timer(this.components);
            this.khra = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.guna2ContextMenuStrip2.SuspendLayout();
            this.guna2ContextMenuStrip3.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.startCirclePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.Transparent;
            this.photo.CustomizableEdges.TopRight = false;
            this.photo.ErrorImage = null;
            this.photo.FillColor = System.Drawing.Color.Transparent;
            this.photo.ImageRotate = 0F;
            this.photo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.photo.InitialImage = null;
            this.photo.Location = new System.Drawing.Point(-1, 31);
            this.photo.Name = "photo";
            this.photo.ShadowDecoration.BorderRadius = 33;
            this.photo.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.photo.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.photo.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.photo.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.photo.Size = new System.Drawing.Size(670, 297);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 31;
            this.photo.TabStop = false;
            this.photo.UseTransparentBackground = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(1064, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1036, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 1400;
            // 
            // malki
            // 
            this.malki.AcceptsReturn = true;
            this.malki.AcceptsTab = true;
            this.malki.AllowDrop = true;
            this.malki.Animated = true;
            this.malki.AutoRoundedCorners = true;
            this.malki.BackColor = System.Drawing.Color.Silver;
            this.malki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.malki.BorderColor = System.Drawing.Color.Yellow;
            this.malki.BorderRadius = 18;
            this.malki.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.malki.BorderThickness = 2;
            this.malki.CausesValidation = false;
            this.malki.Cursor = System.Windows.Forms.Cursors.Cross;
            this.malki.CustomizableEdges.BottomLeft = false;
            this.malki.CustomizableEdges.TopRight = false;
            this.malki.DefaultText = "";
            this.malki.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.malki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.malki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.malki.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.malki.FillColor = System.Drawing.Color.Black;
            this.malki.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.malki.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.malki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.malki.HideSelection = false;
            this.malki.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.malki.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.malki.IconLeftSize = new System.Drawing.Size(26, 24);
            this.malki.Location = new System.Drawing.Point(1, 332);
            this.malki.Margin = new System.Windows.Forms.Padding(4);
            this.malki.Multiline = true;
            this.malki.Name = "malki";
            this.malki.PasswordChar = '\0';
            this.malki.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.malki.PlaceholderText = "";
            this.malki.ReadOnly = true;
            this.malki.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.malki.SelectedText = "";
            this.malki.ShortcutsEnabled = false;
            this.malki.Size = new System.Drawing.Size(669, 38);
            this.malki.TabIndex = 26;
            this.malki.TabStop = false;
            this.malki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.malki.WordWrap = false;
            // 
            // addTextWithAnimation
            // 
            this.addTextWithAnimation.Enabled = true;
            // 
            // animatedText
            // 
            this.animatedText.Enabled = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.AllowDrop = true;
            this.guna2ContextMenuStrip1.AutoSize = false;
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(25, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripSeparator1,
            this.toolStripMenuItem7,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripComboBox3,
            this.toolStripTextBox2,
            this.toolStripSeparator5,
            this.toolStripComboBox2,
            this.toolStripMenuItem8});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.guna2ContextMenuStrip1.ShowCheckMargin = true;
            this.guna2ContextMenuStrip1.ShowItemToolTips = false;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(192, 238);
            this.guna2ContextMenuStrip1.TabStop = true;
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem6.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem6.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem6.Text = "Anti Stream";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem7.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(207, 30);
            this.toolStripMenuItem7.Text = "Reset Guest";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Red;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 22);
            this.toolStripTextBox1.Text = "نوع البرنامج";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripComboBox3.Enabled = false;
            this.toolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripComboBox3.ForeColor = System.Drawing.Color.White;
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 24);
            this.toolStripComboBox3.Text = "Bypass/phone";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripTextBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox2.ForeColor = System.Drawing.Color.Red;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 22);
            this.toolStripTextBox2.Text = "أختيار اصدار اللعبة";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripComboBox2.ForeColor = System.Drawing.Color.Black;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "GLOBAL |عالمية",
            "VETNAM |فيتنامية",
            "KOREA | كورية"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 24);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.CheckOnClick = true;
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(207, 30);
            this.toolStripMenuItem8.Text = "Hack Internal";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem5.Text = "skip Update";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem4.Text = "90FPS";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Lime;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem2.Text = "Ipad View";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "GLOBAL",
            "VETNAM"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem1.Text = "HACK INTERNAL";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.Location = new System.Drawing.Point(606, 248);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.Size = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.TabIndex = 39;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem3.Text = "Start bypass";
            // 
            // EX
            // 
            this.EX.AutoSize = true;
            this.EX.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.EX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EX.Location = new System.Drawing.Point(130, 520);
            this.EX.Name = "EX";
            this.EX.Size = new System.Drawing.Size(0, 16);
            this.EX.TabIndex = 12;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.AllowMerge = false;
            this.contextMenuStrip2.BackColor = System.Drawing.Color.AliceBlue;
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(25, 24);
            this.contextMenuStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.toolStripMenuItem16,
            this.toolStripSeparator6,
            this.toolStripMenuItem12,
            this.toolStripSeparator7,
            this.toolStripMenuItem13,
            this.toolStripSeparator8,
            this.toolStripMenuItem14,
            this.toolStripSeparator9,
            this.toolStripMenuItem21,
            this.toolStripSeparator14,
            this.toolStripMenuItem22,
            this.toolStripSeparator15,
            this.toolStripMenuItem23,
            this.toolStripSeparator19});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.ShowCheckMargin = true;
            this.contextMenuStrip2.ShowItemToolTips = false;
            this.contextMenuStrip2.Size = new System.Drawing.Size(301, 218);
            this.contextMenuStrip2.TabStop = true;
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox4.ForeColor = System.Drawing.Color.Red;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.ReadOnly = true;
            this.toolStripTextBox4.Size = new System.Drawing.Size(218, 16);
            this.toolStripTextBox4.Text = "Color Green = Normal : Color red = Risk";
            this.toolStripTextBox4.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.BackColor = System.Drawing.Color.Lime;
            this.toolStripMenuItem16.CheckOnClick = true;
            this.toolStripMenuItem16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem16.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripMenuItem16.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem16.Text = "Ipad View";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.CheckOnClick = true;
            this.toolStripMenuItem12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem12.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem12.Text = "90 FPS";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.CheckOnClick = true;
            this.toolStripMenuItem13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem13.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem13.Text = "UHD";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator8.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.CheckOnClick = true;
            this.toolStripMenuItem14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem14.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem14.Text = "Night Mode";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator9.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.CheckOnClick = true;
            this.toolStripMenuItem21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem21.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem21.Text = "Small Crosshair";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator14.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.CheckOnClick = true;
            this.toolStripMenuItem22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem22.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem22.Text = "Fix Ping";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator15.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.CheckOnClick = true;
            this.toolStripMenuItem23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem23.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(300, 22);
            this.toolStripMenuItem23.Text = "X EFFECT";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(297, 6);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton2.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(44, 44);
            this.guna2ImageButton2.Location = new System.Drawing.Point(-1, 31);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton2.Size = new System.Drawing.Size(50, 50);
            this.guna2ImageButton2.TabIndex = 42;
            this.guna2ImageButton2.UseTransparentBackground = true;
            this.guna2ImageButton2.Visible = false;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton3.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(44, 44);
            this.guna2ImageButton3.Location = new System.Drawing.Point(14, 248);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton3.Size = new System.Drawing.Size(50, 50);
            this.guna2ImageButton3.TabIndex = 43;
            this.guna2ImageButton3.UseTransparentBackground = true;
            // 
            // guna2ContextMenuStrip2
            // 
            this.guna2ContextMenuStrip2.AllowMerge = false;
            this.guna2ContextMenuStrip2.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(30, 28);
            this.guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripSeparator16,
            this.toolStripMenuItem17,
            this.toolStripSeparator10,
            this.toolStripMenuItem18,
            this.toolStripSeparator11,
            this.toolStripMenuItem19,
            this.toolStripSeparator12,
            this.toolStripMenuItem20,
            this.toolStripSeparator4,
            this.toolStripMenuItem9,
            this.toolStripSeparator20,
            this.toolStripMenuItem24,
            this.toolStripSeparator21});
            this.guna2ContextMenuStrip2.Name = "guna2ContextMenuStrip2";
            this.guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.AliceBlue;
            this.guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.AliceBlue;
            this.guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip2.RenderStyle.RoundedEdges = false;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.Silver;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip2.ShowItemToolTips = false;
            this.guna2ContextMenuStrip2.Size = new System.Drawing.Size(167, 201);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem15.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem15.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem15.Text = "         Discord";
            this.toolStripMenuItem15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem17.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem17.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem17.Text = "         Telegram";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.AutoSize = false;
            this.toolStripSeparator10.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator10.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator10.MergeIndex = 1;
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Padding = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator10.Size = new System.Drawing.Size(163, 7);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem18.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem18.Text = "         ";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem19.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(166, 22);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem20.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(166, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(166, 22);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem24.ForeColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(166, 22);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(163, 6);
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton5.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(44, 22);
            this.guna2ImageButton5.Location = new System.Drawing.Point(623, 334);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton5.Size = new System.Drawing.Size(37, 32);
            this.guna2ImageButton5.TabIndex = 45;
            this.guna2ImageButton5.UseTransparentBackground = true;
            // 
            // guna2ContextMenuStrip3
            // 
            this.guna2ContextMenuStrip3.AllowMerge = false;
            this.guna2ContextMenuStrip3.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2ContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(30, 28);
            this.guna2ContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripSeparator13,
            this.toolStripMenuItem11,
            this.toolStripSeparator18});
            this.guna2ContextMenuStrip3.Name = "guna2ContextMenuStrip3";
            this.guna2ContextMenuStrip3.RenderStyle.ArrowColor = System.Drawing.Color.DarkGray;
            this.guna2ContextMenuStrip3.RenderStyle.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ContextMenuStrip3.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip3.RenderStyle.RoundedEdges = false;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionArrowColor = System.Drawing.Color.DarkGray;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.guna2ContextMenuStrip3.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2ContextMenuStrip3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip3.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip3.ShowItemToolTips = false;
            this.guna2ContextMenuStrip3.Size = new System.Drawing.Size(173, 60);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem10.Text = "         Safe Exit";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem11.Text = "         Mini Mize";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(169, 6);
            // 
            // tttmer
            // 
            this.tttmer.BackColor = System.Drawing.Color.Silver;
            this.tttmer.BorderColor = System.Drawing.Color.Transparent;
            this.tttmer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tttmer.DefaultText = "00:00:00";
            this.tttmer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tttmer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tttmer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tttmer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tttmer.FillColor = System.Drawing.Color.Black;
            this.tttmer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tttmer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
            this.tttmer.ForeColor = System.Drawing.Color.Blue;
            this.tttmer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tttmer.Location = new System.Drawing.Point(14, 340);
            this.tttmer.Margin = new System.Windows.Forms.Padding(4);
            this.tttmer.Name = "tttmer";
            this.tttmer.PasswordChar = '\0';
            this.tttmer.PlaceholderText = "";
            this.tttmer.SelectedText = "";
            this.tttmer.Size = new System.Drawing.Size(86, 21);
            this.tttmer.TabIndex = 49;
            this.tttmer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(41, 41);
            this.guna2ImageButton6.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.guna2ImageButton6.Location = new System.Drawing.Point(86, 248);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton6.Size = new System.Drawing.Size(50, 50);
            this.guna2ImageButton6.TabIndex = 50;
            this.guna2ImageButton6.UseTransparentBackground = true;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.BackColor = System.Drawing.Color.AliceBlue;
            this.contextMenuStrip3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.contextMenuStrip3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.toolStripSeparator17,
            this.toolStripComboBox4});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip3.ShowImageMargin = false;
            this.contextMenuStrip3.Size = new System.Drawing.Size(157, 62);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AcceptsReturn = true;
            this.toolStripTextBox3.AcceptsTab = true;
            this.toolStripTextBox3.AutoToolTip = true;
            this.toolStripTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox3.ForeColor = System.Drawing.Color.Red;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "Select language";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripComboBox4.ForeColor = System.Drawing.Color.Black;
            this.toolStripComboBox4.Items.AddRange(new object[] {
            "Arabic",
            "English"});
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 23);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            // 
            // crack
            // 
            this.crack.Enabled = true;
            this.crack.Interval = 4000;
            // 
            // program
            // 
            this.program.Enabled = true;
            this.program.Interval = 4000;
            // 
            // khaledmalki
            // 
            this.khaledmalki.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.khaledmalki.Caption = null;
            this.khaledmalki.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.khaledmalki.Parent = null;
            this.khaledmalki.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.khaledmalki.Text = "";
            // 
            // check
            // 
            this.check.Enabled = true;
            this.check.Interval = 1800;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.Animated = true;
            this.guna2GradientCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GradientCircleButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientCircleButton1.BorderThickness = 1;
            this.guna2GradientCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientCircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guna2GradientCircleButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.guna2GradientCircleButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientCircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientCircleButton1.IndicateFocus = true;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(8, 8);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(50, 50);
            this.guna2GradientCircleButton1.TabIndex = 11;
            this.guna2GradientCircleButton1.UseTransparentBackground = true;
            // 
            // startCirclePnl
            // 
            this.startCirclePnl.BackColor = System.Drawing.Color.Transparent;
            this.startCirclePnl.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startCirclePnl.BorderRadius = 31;
            this.startCirclePnl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.startCirclePnl.BorderThickness = 1;
            this.startCirclePnl.Controls.Add(this.guna2GradientCircleButton1);
            this.startCirclePnl.FillColor = System.Drawing.Color.FloralWhite;
            this.startCirclePnl.FillColor2 = System.Drawing.Color.Black;
            this.startCirclePnl.ForeColor = System.Drawing.Color.Cornsilk;
            this.startCirclePnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.startCirclePnl.Location = new System.Drawing.Point(14, 132);
            this.startCirclePnl.Name = "startCirclePnl";
            this.startCirclePnl.ShadowDecoration.BorderRadius = 110;
            this.startCirclePnl.ShadowDecoration.Depth = 1;
            this.startCirclePnl.ShadowDecoration.Enabled = true;
            this.startCirclePnl.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.startCirclePnl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.startCirclePnl.Size = new System.Drawing.Size(66, 66);
            this.startCirclePnl.TabIndex = 56;
            this.startCirclePnl.UseTransparentBackground = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(0, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(672, 23);
            this.textBox2.TabIndex = 60;
            // 
            // titleLbl
            // 
            this.titleLbl.AcceptsReturn = true;
            this.titleLbl.AcceptsTab = true;
            this.titleLbl.AllowDrop = true;
            this.titleLbl.Animated = true;
            this.titleLbl.AutoRoundedCorners = true;
            this.titleLbl.BackColor = System.Drawing.Color.Silver;
            this.titleLbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleLbl.BorderColor = System.Drawing.Color.Yellow;
            this.titleLbl.BorderRadius = 17;
            this.titleLbl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.titleLbl.BorderThickness = 2;
            this.titleLbl.CausesValidation = false;
            this.titleLbl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.titleLbl.DefaultText = "";
            this.titleLbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleLbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleLbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleLbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleLbl.FillColor = System.Drawing.Color.Black;
            this.titleLbl.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.HideSelection = false;
            this.titleLbl.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.titleLbl.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.titleLbl.IconLeftSize = new System.Drawing.Size(26, 24);
            this.titleLbl.Location = new System.Drawing.Point(0, -1);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4);
            this.titleLbl.Multiline = true;
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.PasswordChar = '\0';
            this.titleLbl.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.titleLbl.PlaceholderText = "";
            this.titleLbl.ReadOnly = true;
            this.titleLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleLbl.SelectedText = "";
            this.titleLbl.ShortcutsEnabled = false;
            this.titleLbl.Size = new System.Drawing.Size(669, 36);
            this.titleLbl.TabIndex = 62;
            this.titleLbl.TabStop = false;
            this.titleLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.titleLbl.WordWrap = false;
            // 
            // subtitleLbl
            // 
            this.subtitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLbl.ForeColor = System.Drawing.Color.DimGray;
            this.subtitleLbl.Location = new System.Drawing.Point(140, 15);
            this.subtitleLbl.Name = "subtitleLbl";
            this.subtitleLbl.Size = new System.Drawing.Size(113, 20);
            this.subtitleLbl.TabIndex = 58;
            this.subtitleLbl.Text = "SUBTITLE";
            this.subtitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 33;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Silver;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0D;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.1D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 0.1D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(-1, 309);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 23);
            this.textBox1.TabIndex = 63;
            // 
            // chechiking
            // 
            this.chechiking.Interval = 2000;
            // 
            // BP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 371);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.subtitleLbl);
            this.Controls.Add(this.startCirclePnl);
            this.Controls.Add(this.guna2ImageButton6);
            this.Controls.Add(this.tttmer);
            this.Controls.Add(this.guna2ImageButton5);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EX);
            this.Controls.Add(this.malki);
            this.Controls.Add(this.photo);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BP";
            this.Opacity = 0.81D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.guna2ContextMenuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            this.guna2ContextMenuStrip2.ResumeLayout(false);
            this.guna2ContextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip3.PerformLayout();
            this.startCirclePnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox photo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Timer addTextWithAnimation;
        private System.Windows.Forms.Timer animatedText;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label EX;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private Guna.UI2.WinForms.Guna2TextBox tttmer;
        private System.Windows.Forms.Timer chackgameloop;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer crack;
        private System.Windows.Forms.Timer program;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private Guna.UI2.WinForms.Guna2MessageDialog khaledmalki;
        public Guna.UI2.WinForms.Guna2TextBox malki;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer check;
        private System.Windows.Forms.Timer pubgm;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientPanel startCirclePnl;
        private System.Windows.Forms.TextBox textBox2;
        public Guna.UI2.WinForms.Guna2TextBox titleLbl;
        private System.Windows.Forms.Label subtitleLbl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer chechiking;
        private System.ComponentModel.BackgroundWorker khra;
    }
}

