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
    public partial class PatRecordWidget : UserControl
    {
        public PatRecordWidget()
        {
            InitializeComponent();
        }
        private string _reccard,_recname,_recdob,_recgen,_recreas,_recdtime;
        public string RecCard
        {
            get { return _reccard; }
            set { _reccard = value; Rec_Card.Text = value; }
        }
        public string RecName
        {
            get { return _recname; }
            set { _recname = value; Rec_Name.Text = value; }
        }
        public string RecDOB
        {
            get { return _recdob; }
            set { _recdob = value; Rec_Dob.Text = value; }
        }
        public string RecGender
        {
            get { return _recgen; }
            set { _recgen = value; Rec_Gend.Text = value; }
        }
        public string RecReas
        {
            get { return _recreas; }
            set { _recreas = value; Rec_Reas.Text = value; }
        }
        public string RecCreated
        {
            get { return _recdtime; }
            set { _recdtime = value; Rec_DTime.Text = value; }
        }
        private void PatRecordWidget_Load(object sender, EventArgs e)
        {

        }

        private void ClickColor_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 50, 52);
        }

        private void ClickColor_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }
    }
}
