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
    public partial class PatOrdWidget : UserControl
    {
        public PatOrdWidget()
        {
            InitializeComponent();
        }
        private string _idord,_idcard,_idpat,_iddoctor,_idemail,_iddate,_idtime;
        public event EventHandler OnSelect = null;
        public string IDOrd
        {
            get { return _idord; }
            set { _idord = value; IDO_T.Text = value; }
        }
        public string IDCard
        {
            get { return _idcard; }
            set { _idcard = value; IDC_T.Text = value; }
        }
        public string IDPat
        {
            get { return _idpat; }
            set { _idpat = value; IDP_T.Text = value; }
        }
        public string IDDocs
        {
            get { return _iddoctor; }
            set { _iddoctor = value; IDD_T.Text = value; }
        }
        public string IDEmail
        {
            get { return _idemail; }
            set { _idemail = value; IDE_T.Text = value; }
        }
        public string IDDate
        {
            get { return _iddate; }
            set { _iddate = value; IDT_T.Text = value; }
        }
        public string IDTime
        {
            get { return _idtime; }
            set { _idtime = value; IDTI_T.Text = value; }
        }
        private void PatOrdWidget_Load(object sender, EventArgs e)
        {

        }
        private void ColorClick_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 50, 52);
        }

        private void ColorClick_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }

        private void Doc_Del_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
