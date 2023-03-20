
namespace EMedical
{
    partial class DoctorWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorWidget));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Doc_Img = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Doc_Creat = new System.Windows.Forms.Label();
            this.Doc_Edit = new System.Windows.Forms.PictureBox();
            this.Doc_Del = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Doc_ID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Doc_Name = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Doc_Em = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Doc_Role = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Doc_Gender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_Img)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_Del)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Doc_Img
            // 
            this.Doc_Img.BackColor = System.Drawing.Color.Transparent;
            this.Doc_Img.BorderRadius = 15;
            this.Doc_Img.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.Doc_Img.Image = ((System.Drawing.Image)(resources.GetObject("Doc_Img.Image")));
            this.Doc_Img.ImageRotate = 0F;
            this.Doc_Img.InitialImage = null;
            this.Doc_Img.Location = new System.Drawing.Point(712, 6);
            this.Doc_Img.Name = "Doc_Img";
            this.Doc_Img.Size = new System.Drawing.Size(30, 30);
            this.Doc_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Doc_Img.TabIndex = 155;
            this.Doc_Img.TabStop = false;
            this.Doc_Img.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Img.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Doc_Creat);
            this.panel7.Location = new System.Drawing.Point(759, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 31);
            this.panel7.TabIndex = 156;
            this.panel7.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // Doc_Creat
            // 
            this.Doc_Creat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_Creat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Doc_Creat.ForeColor = System.Drawing.Color.Gainsboro;
            this.Doc_Creat.Location = new System.Drawing.Point(0, 0);
            this.Doc_Creat.MinimumSize = new System.Drawing.Size(117, 31);
            this.Doc_Creat.Name = "Doc_Creat";
            this.Doc_Creat.Size = new System.Drawing.Size(190, 31);
            this.Doc_Creat.TabIndex = 100;
            this.Doc_Creat.Text = "Created profile";
            this.Doc_Creat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doc_Creat.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Creat.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // Doc_Edit
            // 
            this.Doc_Edit.Image = ((System.Drawing.Image)(resources.GetObject("Doc_Edit.Image")));
            this.Doc_Edit.Location = new System.Drawing.Point(955, 6);
            this.Doc_Edit.Name = "Doc_Edit";
            this.Doc_Edit.Size = new System.Drawing.Size(31, 31);
            this.Doc_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Doc_Edit.TabIndex = 157;
            this.Doc_Edit.TabStop = false;
            this.Doc_Edit.Click += new System.EventHandler(this.Doc_Edit_Click);
            this.Doc_Edit.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Edit.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // Doc_Del
            // 
            this.Doc_Del.Image = ((System.Drawing.Image)(resources.GetObject("Doc_Del.Image")));
            this.Doc_Del.Location = new System.Drawing.Point(993, 6);
            this.Doc_Del.Name = "Doc_Del";
            this.Doc_Del.Size = new System.Drawing.Size(31, 31);
            this.Doc_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Doc_Del.TabIndex = 158;
            this.Doc_Del.TabStop = false;
            this.Doc_Del.Click += new System.EventHandler(this.Doc_Del_Click);
            this.Doc_Del.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Del.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Doc_ID);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 31);
            this.panel2.TabIndex = 159;
            this.panel2.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // Doc_ID
            // 
            this.Doc_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_ID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Doc_ID.ForeColor = System.Drawing.Color.Gainsboro;
            this.Doc_ID.Location = new System.Drawing.Point(0, 0);
            this.Doc_ID.Name = "Doc_ID";
            this.Doc_ID.Size = new System.Drawing.Size(53, 31);
            this.Doc_ID.TabIndex = 100;
            this.Doc_ID.Text = "ID";
            this.Doc_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doc_ID.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_ID.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Doc_Name);
            this.panel4.Location = new System.Drawing.Point(60, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 31);
            this.panel4.TabIndex = 160;
            // 
            // Doc_Name
            // 
            this.Doc_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_Name.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Doc_Name.ForeColor = System.Drawing.Color.Gainsboro;
            this.Doc_Name.Location = new System.Drawing.Point(0, 0);
            this.Doc_Name.MinimumSize = new System.Drawing.Size(117, 31);
            this.Doc_Name.Name = "Doc_Name";
            this.Doc_Name.Size = new System.Drawing.Size(152, 31);
            this.Doc_Name.TabIndex = 100;
            this.Doc_Name.Text = "Name Doc";
            this.Doc_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doc_Name.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Name.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Doc_Em);
            this.panel8.Location = new System.Drawing.Point(218, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(152, 31);
            this.panel8.TabIndex = 161;
            // 
            // Doc_Em
            // 
            this.Doc_Em.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_Em.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Doc_Em.ForeColor = System.Drawing.Color.Gainsboro;
            this.Doc_Em.Location = new System.Drawing.Point(0, 0);
            this.Doc_Em.MinimumSize = new System.Drawing.Size(117, 31);
            this.Doc_Em.Name = "Doc_Em";
            this.Doc_Em.Size = new System.Drawing.Size(152, 31);
            this.Doc_Em.TabIndex = 100;
            this.Doc_Em.Text = "Email Doc";
            this.Doc_Em.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doc_Em.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Em.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Doc_Role);
            this.panel9.Location = new System.Drawing.Point(377, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(152, 31);
            this.panel9.TabIndex = 162;
            // 
            // Doc_Role
            // 
            this.Doc_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_Role.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Doc_Role.ForeColor = System.Drawing.Color.Gainsboro;
            this.Doc_Role.Location = new System.Drawing.Point(0, 0);
            this.Doc_Role.MinimumSize = new System.Drawing.Size(117, 31);
            this.Doc_Role.Name = "Doc_Role";
            this.Doc_Role.Size = new System.Drawing.Size(152, 31);
            this.Doc_Role.TabIndex = 100;
            this.Doc_Role.Text = "Role Doc";
            this.Doc_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doc_Role.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Role.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Doc_Gender);
            this.panel10.Location = new System.Drawing.Point(535, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(152, 31);
            this.panel10.TabIndex = 163;
            // 
            // Doc_Gender
            // 
            this.Doc_Gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc_Gender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Doc_Gender.ForeColor = System.Drawing.Color.Gainsboro;
            this.Doc_Gender.Location = new System.Drawing.Point(0, 0);
            this.Doc_Gender.MinimumSize = new System.Drawing.Size(117, 31);
            this.Doc_Gender.Name = "Doc_Gender";
            this.Doc_Gender.Size = new System.Drawing.Size(152, 31);
            this.Doc_Gender.TabIndex = 100;
            this.Doc_Gender.Text = "Gender Doc";
            this.Doc_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doc_Gender.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.Doc_Gender.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            // 
            // DoctorWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Doc_Del);
            this.Controls.Add(this.Doc_Edit);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Doc_Img);
            this.Name = "DoctorWidget";
            this.Size = new System.Drawing.Size(1027, 47);
            this.Load += new System.EventHandler(this.DoctorWidget_Load);
            this.MouseEnter += new System.EventHandler(this.ClickColor_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ClickColor_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Doc_Img)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Doc_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_Del)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Doc_Creat;
        private Guna.UI2.WinForms.Guna2PictureBox Doc_Img;
        private System.Windows.Forms.PictureBox Doc_Del;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Doc_ID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Doc_Name;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label Doc_Gender;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label Doc_Role;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Doc_Em;
        public System.Windows.Forms.PictureBox Doc_Edit;
    }
}
