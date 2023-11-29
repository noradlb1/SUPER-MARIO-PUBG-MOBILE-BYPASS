namespace numer
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BW_loginBtn = new System.ComponentModel.BackgroundWorker();
            this.hdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.key = new Guna.UI2.WinForms.Guna2TextBox();
            this.random1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkk = new System.ComponentModel.BackgroundWorker();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.BW_hotkeys = new System.ComponentModel.BackgroundWorker();
            this.status = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.animatedText = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.check = new System.Windows.Forms.Timer(this.components);
            this.text = new System.ComponentModel.BackgroundWorker();
            this.prr = new System.ComponentModel.BackgroundWorker();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.loginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // BW_loginBtn
            // 
            this.BW_loginBtn.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_loginBtn_DoWork);
            // 
            // hdd
            // 
            this.hdd.Animated = true;
            this.hdd.AutoRoundedCorners = true;
            this.hdd.BackColor = System.Drawing.Color.Transparent;
            this.hdd.BorderColor = System.Drawing.Color.Blue;
            this.hdd.BorderRadius = 11;
            this.hdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.hdd.BorderThickness = 3;
            this.hdd.Cursor = System.Windows.Forms.Cursors.Cross;
            this.hdd.CustomizableEdges.BottomLeft = false;
            this.hdd.CustomizableEdges.TopRight = false;
            this.hdd.DefaultText = "\r\n";
            this.hdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hdd.FillColor = System.Drawing.Color.Transparent;
            this.hdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hdd.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.hdd.ForeColor = System.Drawing.Color.SkyBlue;
            this.hdd.HideSelection = false;
            this.hdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hdd.Location = new System.Drawing.Point(101, 19);
            this.hdd.Margin = new System.Windows.Forms.Padding(4);
            this.hdd.Name = "hdd";
            this.hdd.PasswordChar = '\0';
            this.hdd.PlaceholderForeColor = System.Drawing.Color.Red;
            this.hdd.PlaceholderText = "";
            this.hdd.ReadOnly = true;
            this.hdd.SelectedText = "";
            this.hdd.Size = new System.Drawing.Size(446, 25);
            this.hdd.TabIndex = 15;
            this.hdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hdd.WordWrap = false;
            // 
            // key
            // 
            this.key.AcceptsReturn = true;
            this.key.AcceptsTab = true;
            this.key.AllowDrop = true;
            this.key.Animated = true;
            this.key.AutoRoundedCorners = true;
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.BorderColor = System.Drawing.Color.DarkBlue;
            this.key.BorderRadius = 12;
            this.key.BorderThickness = 2;
            this.key.Cursor = System.Windows.Forms.Cursors.Cross;
            this.key.CustomizableEdges.BottomLeft = false;
            this.key.CustomizableEdges.TopRight = false;
            this.key.DefaultText = "\r\n";
            this.key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.FillColor = System.Drawing.Color.Transparent;
            this.key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.key.ForeColor = System.Drawing.Color.Lavender;
            this.key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key.IconLeftSize = new System.Drawing.Size(35, 27);
            this.key.IconRightSize = new System.Drawing.Size(35, 28);
            this.key.Location = new System.Drawing.Point(32, 94);
            this.key.Margin = new System.Windows.Forms.Padding(4);
            this.key.Name = "key";
            this.key.PasswordChar = '\0';
            this.key.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.key.PlaceholderText = "";
            this.key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.key.SelectedText = "";
            this.key.Size = new System.Drawing.Size(601, 27);
            this.key.TabIndex = 15;
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // random1
            // 
            this.random1.Animated = true;
            this.random1.AutoRoundedCorners = true;
            this.random1.BackColor = System.Drawing.Color.Transparent;
            this.random1.BorderColor = System.Drawing.Color.Blue;
            this.random1.BorderRadius = 11;
            this.random1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.random1.BorderThickness = 10;
            this.random1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.random1.DefaultText = "\r\n";
            this.random1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.random1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.random1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.random1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.random1.FillColor = System.Drawing.Color.Transparent;
            this.random1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.random1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.random1.ForeColor = System.Drawing.Color.Lavender;
            this.random1.HideSelection = false;
            this.random1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.random1.Location = new System.Drawing.Point(244, 164);
            this.random1.Margin = new System.Windows.Forms.Padding(4);
            this.random1.Name = "random1";
            this.random1.PasswordChar = '\0';
            this.random1.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.random1.PlaceholderText = "";
            this.random1.ReadOnly = true;
            this.random1.SelectedText = "";
            this.random1.Size = new System.Drawing.Size(202, 25);
            this.random1.TabIndex = 17;
            this.random1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.random1.WordWrap = false;
            // 
            // checkk
            // 
            this.checkk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkk_DoWork_1);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox1.BorderRadius = 9;
            this.guna2TextBox1.BorderThickness = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.CustomizableEdges.BottomLeft = false;
            this.guna2TextBox1.CustomizableEdges.TopRight = false;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(248, 214);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Red;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 21);
            this.guna2TextBox1.TabIndex = 18;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.guna2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // status
            // 
            this.status.Animated = true;
            this.status.AutoRoundedCorners = true;
            this.status.BorderColor = System.Drawing.Color.ForestGreen;
            this.status.BorderRadius = 17;
            this.status.BorderThickness = 3;
            this.status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.status.CustomizableEdges.BottomLeft = false;
            this.status.CustomizableEdges.TopRight = false;
            this.status.DefaultText = "\r\n";
            this.status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status.FillColor = System.Drawing.Color.Transparent;
            this.status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.Lime;
            this.status.HideSelection = false;
            this.status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.IconLeftCursor = System.Windows.Forms.Cursors.SizeNESW;
            this.status.IconLeftSize = new System.Drawing.Size(30, 29);
            this.status.Location = new System.Drawing.Point(3, 333);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.PasswordChar = '\0';
            this.status.PlaceholderForeColor = System.Drawing.Color.Lime;
            this.status.PlaceholderText = "";
            this.status.ReadOnly = true;
            this.status.SelectedText = "";
            this.status.ShadowDecoration.BorderRadius = 10;
            this.status.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.status.Size = new System.Drawing.Size(669, 37);
            this.status.TabIndex = 21;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.WordWrap = false;
            this.status.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // animatedText
            // 
            this.animatedText.Tick += new System.EventHandler(this.animatedText_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(641, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(2, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(670, 21);
            this.textBox1.TabIndex = 29;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 600;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 22;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // check
            // 
            this.check.Enabled = true;
            this.check.Interval = 1000;
            this.check.Tick += new System.EventHandler(this.check_Tick);
            // 
            // text
            // 
            this.text.DoWork += new System.ComponentModel.DoWorkEventHandler(this.text_DoWork);
            // 
            // prr
            // 
            this.prr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.prr_DoWork);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Blue;
            this.guna2GradientButton1.BorderRadius = 18;
            this.guna2GradientButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2GradientButton1.BorderThickness = 3;
            this.guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2GradientButton1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.CustomizableEdges.BottomLeft = false;
            this.guna2GradientButton1.CustomizableEdges.TopRight = false;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.IndicateFocus = true;
            this.guna2GradientButton1.Location = new System.Drawing.Point(268, 257);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.Color.Blue;
            this.guna2GradientButton1.PressedDepth = 55;
            this.guna2GradientButton1.ShadowDecoration.BorderRadius = 10;
            this.guna2GradientButton1.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.guna2GradientButton1.Size = new System.Drawing.Size(154, 39);
            this.guna2GradientButton1.TabIndex = 30;
            this.guna2GradientButton1.Text = "Login";
            this.guna2GradientButton1.TextFormatNoPrefix = true;
            this.guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2GradientButton1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AutoRoundedCorners = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderColor = System.Drawing.Color.Blue;
            this.loginBtn.BorderRadius = 18;
            this.loginBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.loginBtn.BorderThickness = 3;
            this.loginBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.loginBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.loginBtn.CustomizableEdges.BottomLeft = false;
            this.loginBtn.CustomizableEdges.TopRight = false;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.Transparent;
            this.loginBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
            this.loginBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBtn.IndicateFocus = true;
            this.loginBtn.Location = new System.Drawing.Point(469, 196);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.PressedColor = System.Drawing.Color.Blue;
            this.loginBtn.PressedDepth = 55;
            this.loginBtn.ShadowDecoration.BorderRadius = 10;
            this.loginBtn.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.loginBtn.Size = new System.Drawing.Size(154, 39);
            this.loginBtn.TabIndex = 24;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextFormatNoPrefix = true;
            this.loginBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.loginBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.loginBtn.UseTransparentBackground = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(675, 372);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.random1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.hdd);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BW_loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox hdd;
        private Guna.UI2.WinForms.Guna2TextBox key;
        private Guna.UI2.WinForms.Guna2TextBox random1;
        private System.ComponentModel.BackgroundWorker checkk;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.ComponentModel.BackgroundWorker BW_hotkeys;
        private Guna.UI2.WinForms.Guna2TextBox status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer animatedText;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer check;
        private System.ComponentModel.BackgroundWorker text;
        private System.ComponentModel.BackgroundWorker prr;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton loginBtn;
    }
}