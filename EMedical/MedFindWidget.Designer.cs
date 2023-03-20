
namespace EMedical
{
    partial class MedFindWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedFindWidget));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.folderPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatFin_Creat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.folderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // folderPic
            // 
            this.folderPic.Image = ((System.Drawing.Image)(resources.GetObject("folderPic.Image")));
            this.folderPic.Location = new System.Drawing.Point(14, 7);
            this.folderPic.Name = "folderPic";
            this.folderPic.Size = new System.Drawing.Size(107, 99);
            this.folderPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.folderPic.TabIndex = 0;
            this.folderPic.TabStop = false;
            this.folderPic.MouseEnter += new System.EventHandler(this.ClColor_MouseEnter);
            this.folderPic.MouseLeave += new System.EventHandler(this.ClColor_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Date created";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.ClColor_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ClColor_MouseLeave);
            // 
            // DatFin_Creat
            // 
            this.DatFin_Creat.AutoSize = true;
            this.DatFin_Creat.BackColor = System.Drawing.Color.Transparent;
            this.DatFin_Creat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatFin_Creat.ForeColor = System.Drawing.Color.White;
            this.DatFin_Creat.Location = new System.Drawing.Point(14, 130);
            this.DatFin_Creat.Name = "DatFin_Creat";
            this.DatFin_Creat.Size = new System.Drawing.Size(109, 17);
            this.DatFin_Creat.TabIndex = 60;
            this.DatFin_Creat.Text = "01/01/2023 00:00";
            this.DatFin_Creat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DatFin_Creat.MouseEnter += new System.EventHandler(this.ClColor_MouseEnter);
            this.DatFin_Creat.MouseLeave += new System.EventHandler(this.ClColor_MouseLeave);
            // 
            // MedFindWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.DatFin_Creat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderPic);
            this.Name = "MedFindWidget";
            this.Size = new System.Drawing.Size(134, 155);
            this.Load += new System.EventHandler(this.MedFindWidget_Load);
            this.MouseEnter += new System.EventHandler(this.ClColor_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ClColor_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.folderPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox folderPic;
        internal System.Windows.Forms.Label DatFin_Creat;
        internal System.Windows.Forms.Label label1;
    }
}
