
namespace EMedical
{
    partial class Login
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.minimiz = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.loginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.PassBox = new ZBobb.AlphaBlendTextBox();
            this.Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.NameBox = new ZBobb.AlphaBlendTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ytBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CustomNotif = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NotTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // minimiz
            // 
            this.minimiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimiz.BackColor = System.Drawing.Color.Transparent;
            this.minimiz.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.minimiz, Guna.UI2.AnimatorNS.DecorationType.None);
            this.minimiz.FillColor = System.Drawing.Color.Transparent;
            this.minimiz.IconColor = System.Drawing.Color.White;
            this.minimiz.Location = new System.Drawing.Point(807, 0);
            this.minimiz.Name = "minimiz";
            this.minimiz.Size = new System.Drawing.Size(39, 36);
            this.minimiz.TabIndex = 42;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.close, Guna.UI2.AnimatorNS.DecorationType.None);
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.IconColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(848, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(48, 37);
            this.close.TabIndex = 41;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label8.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(386, 165);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(119, 33);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "EMedical";
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(346, 40);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(199, 122);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 56;
            this.PictureBox3.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(348, 224);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(210, 15);
            this.Label5.TabIndex = 53;
            this.Label5.Text = "experience modern experience.";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(331, 208);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(249, 15);
            this.Label4.TabIndex = 52;
            this.Label4.Text = "Manage the organization of the clinic,";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.ForeColor = System.Drawing.Color.Silver;
            this.Label3.Location = new System.Drawing.Point(388, 468);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 16);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "Terms of Service";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(329, 447);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(220, 16);
            this.Label9.TabIndex = 67;
            this.Label9.Text = "By logging in,you are agreeing to the";
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AutoRoundedCorners = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 18;
            this.guna2Transition1.SetDecoration(this.loginBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.loginBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(247)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(332, 386);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(223, 39);
            this.loginBtn.TabIndex = 66;
            this.loginBtn.Text = "Sign in";
            this.loginBtn.UseTransparentBackground = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Guna2Separator2
            // 
            this.Guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Separator2.FillColor = System.Drawing.Color.White;
            this.Guna2Separator2.FillThickness = 2;
            this.Guna2Separator2.Location = new System.Drawing.Point(332, 353);
            this.Guna2Separator2.Name = "Guna2Separator2";
            this.Guna2Separator2.Size = new System.Drawing.Size(223, 10);
            this.Guna2Separator2.TabIndex = 65;
            // 
            // PassBox
            // 
            this.PassBox.BackAlpha = 0;
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2Transition1.SetDecoration(this.PassBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PassBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassBox.ForeColor = System.Drawing.Color.White;
            this.PassBox.Location = new System.Drawing.Point(351, 333);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '•';
            this.PassBox.Size = new System.Drawing.Size(199, 30);
            this.PassBox.TabIndex = 64;
            // 
            // Guna2Separator1
            // 
            this.Guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Separator1.FillColor = System.Drawing.Color.White;
            this.Guna2Separator1.FillThickness = 2;
            this.Guna2Separator1.Location = new System.Drawing.Point(332, 302);
            this.Guna2Separator1.Name = "Guna2Separator1";
            this.Guna2Separator1.Size = new System.Drawing.Size(223, 10);
            this.Guna2Separator1.TabIndex = 63;
            // 
            // NameBox
            // 
            this.NameBox.BackAlpha = 0;
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2Transition1.SetDecoration(this.NameBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(353, 282);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(199, 30);
            this.NameBox.TabIndex = 62;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(329, 315);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 16);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(329, 261);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 16);
            this.Label1.TabIndex = 60;
            this.Label1.Text = "Username";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(332, 334);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(18, 20);
            this.PictureBox2.TabIndex = 59;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(332, 282);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(18, 20);
            this.PictureBox1.TabIndex = 58;
            this.PictureBox1.TabStop = false;
            // 
            // lnBtn
            // 
            this.lnBtn.Animated = true;
            this.lnBtn.BorderColor = System.Drawing.Color.White;
            this.lnBtn.BorderThickness = 1;
            this.guna2Transition1.SetDecoration(this.lnBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lnBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lnBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lnBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lnBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lnBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))));
            this.lnBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnBtn.ForeColor = System.Drawing.Color.White;
            this.lnBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.lnBtn.Image = ((System.Drawing.Image)(resources.GetObject("lnBtn.Image")));
            this.lnBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lnBtn.ImageOffset = new System.Drawing.Point(2, 0);
            this.lnBtn.ImageSize = new System.Drawing.Size(21, 21);
            this.lnBtn.Location = new System.Drawing.Point(360, 533);
            this.lnBtn.Name = "lnBtn";
            this.lnBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(108)))), ((int)(((byte)(110)))));
            this.lnBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.lnBtn.Size = new System.Drawing.Size(45, 45);
            this.lnBtn.TabIndex = 133;
            this.lnBtn.Click += new System.EventHandler(this.lnBtn_Click);
            // 
            // gitBtn
            // 
            this.gitBtn.Animated = true;
            this.gitBtn.BorderColor = System.Drawing.Color.White;
            this.gitBtn.BorderThickness = 1;
            this.guna2Transition1.SetDecoration(this.gitBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))));
            this.gitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gitBtn.ForeColor = System.Drawing.Color.White;
            this.gitBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.gitBtn.Image = ((System.Drawing.Image)(resources.GetObject("gitBtn.Image")));
            this.gitBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gitBtn.ImageOffset = new System.Drawing.Point(4, 0);
            this.gitBtn.ImageSize = new System.Drawing.Size(17, 17);
            this.gitBtn.Location = new System.Drawing.Point(478, 533);
            this.gitBtn.Name = "gitBtn";
            this.gitBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(108)))), ((int)(((byte)(110)))));
            this.gitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gitBtn.Size = new System.Drawing.Size(45, 45);
            this.gitBtn.TabIndex = 135;
            this.gitBtn.Click += new System.EventHandler(this.gitBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(405, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 136;
            this.label7.Text = "Contact us";
            // 
            // ytBtn
            // 
            this.ytBtn.Animated = true;
            this.ytBtn.BorderColor = System.Drawing.Color.White;
            this.ytBtn.BorderThickness = 1;
            this.guna2Transition1.SetDecoration(this.ytBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ytBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ytBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ytBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ytBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ytBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))));
            this.ytBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ytBtn.ForeColor = System.Drawing.Color.White;
            this.ytBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.ytBtn.Image = ((System.Drawing.Image)(resources.GetObject("ytBtn.Image")));
            this.ytBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ytBtn.ImageOffset = new System.Drawing.Point(4, 0);
            this.ytBtn.ImageSize = new System.Drawing.Size(17, 17);
            this.ytBtn.Location = new System.Drawing.Point(419, 533);
            this.ytBtn.Name = "ytBtn";
            this.ytBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(108)))), ((int)(((byte)(110)))));
            this.ytBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ytBtn.Size = new System.Drawing.Size(45, 45);
            this.ytBtn.TabIndex = 134;
            this.ytBtn.Click += new System.EventHandler(this.ytBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomNotif
            // 
            this.CustomNotif.BackColor = System.Drawing.Color.Transparent;
            this.CustomNotif.BorderRadius = 7;
            this.guna2Transition1.SetDecoration(this.CustomNotif, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CustomNotif.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomNotif.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomNotif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomNotif.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomNotif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomNotif.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.CustomNotif.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.CustomNotif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomNotif.ForeColor = System.Drawing.Color.White;
            this.CustomNotif.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.CustomNotif.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.CustomNotif.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomNotif.Location = new System.Drawing.Point(632, 539);
            this.CustomNotif.Name = "CustomNotif";
            this.CustomNotif.PressedDepth = 0;
            this.CustomNotif.Size = new System.Drawing.Size(254, 39);
            this.CustomNotif.TabIndex = 137;
            this.CustomNotif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomNotif.UseTransparentBackground = true;
            // 
            // NotTimer
            // 
            this.NotTimer.Interval = 500;
            this.NotTimer.Tick += new System.EventHandler(this.NotTimer_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.Interval = 15;
            this.guna2Transition1.MaxAnimationTime = 500;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(898, 596);
            this.Controls.Add(this.CustomNotif);
            this.Controls.Add(this.lnBtn);
            this.Controls.Add(this.gitBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ytBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Guna2Separator2);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.Guna2Separator1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.minimiz);
            this.Controls.Add(this.close);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.01D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2ControlBox minimiz;
        internal Guna.UI2.WinForms.Guna2ControlBox close;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label9;
        internal Guna.UI2.WinForms.Guna2GradientButton loginBtn;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator2;
        internal ZBobb.AlphaBlendTextBox PassBox;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal ZBobb.AlphaBlendTextBox NameBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton lnBtn;
        private Guna.UI2.WinForms.Guna2CircleButton gitBtn;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CircleButton ytBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        internal Guna.UI2.WinForms.Guna2GradientButton CustomNotif;
        private System.Windows.Forms.Timer NotTimer;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}

