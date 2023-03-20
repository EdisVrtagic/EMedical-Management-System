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
    public partial class PatientWidget : UserControl
    {
        public PatientWidget()
        {
            InitializeComponent();
        }
        private string _idcard, _patname, _patphone, _pataddr, _patdob, _patgen, _patdoc, _patcreated;
        public event EventHandler OnSelect = null, TwoSelect = null;
        public string PatCard
        {
            get { return _idcard; }
            set { _idcard = value; Pat_CardID.Text = value; }
        }
        public string PatName
        {
            get { return _patname; }
            set { _patname = value; Pat_Nam.Text = value; }
        }
        public string PatPhone
        {
            get { return _patphone; }
            set { _patphone = value; Pat_Ph.Text = value; }
        }
        public string PatAddress
        {
            get { return _pataddr; }
            set { _pataddr = value; Pat_Ad.Text = value; }
        }
        public string PatDOB
        {
            get { return _patdob; }
            set { _patdob = value; Pat_Dob.Text = value; }
        }
        public string PatGender
        {
            get { return _patgen; }
            set { _patgen = value; Pat_Ge.Text = value; }
        }
        public string PatDoctor
        {
            get { return _patdoc; }
            set { _patdoc = value; Pat_Doc.Text = value; }
        }
        public string PatCreated
        {
            get { return _patcreated; }
            set { _patcreated = value; Pat_CPro.Text = value; }
        }
        private void PatientWidget_Load(object sender, EventArgs e)
        {

        }
        private void Pat_Edit_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
        private void Pat_Del_Click(object sender, EventArgs e)
        {
            TwoSelect?.Invoke(this, e);
        }
        private void ClickCol_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 50, 52);
        }
        private void ClickCol_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }
    }
}
