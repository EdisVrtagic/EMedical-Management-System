using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMedical
{
    public partial class MedFindWidget : UserControl
    {
        public MedFindWidget()
        {
            InitializeComponent();
        }
        private string _findcard,_findpat,_finddoc,_finddiag,_findopi,_fincreat;
        public string FindCard
        {
            get { return _findcard; }
            set { _findcard = value; }
        }
        public string FindPatient
        {
            get { return _findpat; }
            set { _findpat = value; }
        }
        public string FindDoctor
        {
            get { return _finddoc; }
            set { _finddoc = value; }
        }
        public string FindDiagnosis
        {
            get { return _finddiag; }
            set { _finddiag = value; }
        }
        public string FindOpinion
        {
            get { return _findopi; }
            set { _findopi = value; }
        }
        public string FindCreated
        {
            get { return _fincreat; }
            set { _fincreat = value; DatFin_Creat.Text = value; }
        }
        private void MedFindWidget_Load(object sender, EventArgs e)
        {
            label1.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            DatFin_Creat.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            folderPic.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
        }
        private void ClColor_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }
        private void ClColor_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 23, 27);
        }
    }
}
