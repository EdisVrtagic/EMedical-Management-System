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
    public partial class DoctorWidget : UserControl
    {
        public DoctorWidget()
        {
            InitializeComponent();
        }
        private Image _docimage;
        private string _docid,_docname,_docemail,_docaddr,_docrole,_docgender,_doccreated;
        public event EventHandler OnSelect = null,TwoSelect = null;
        public Image DocImage
        {
            get { return _docimage; }
            set { _docimage = value; Doc_Img.Image = value; }
        }
        public string DocID
        {
            get { return _docid; }
            set { _docid = value; Doc_ID.Text = value; }
        }
        public string DocName
        {
            get { return _docname; }
            set { _docname = value; Doc_Name.Text = value; }
        }
        public string DocEmail
        {
            get { return _docemail; }
            set { _docemail = value; Doc_Em.Text = value; }
        }
        public string DocAddr
        {
            get { return _docaddr; }
            set { _docaddr = value; }
        }
        public string DocRole
        {
            get { return _docrole; }
            set { _docrole = value; Doc_Role.Text = value; }
        }
        public string DocGend
        {
            get { return _docgender; }
            set { _docgender = value; Doc_Gender.Text = value; }
        }
        public string DocCreated
        {
            get { return _doccreated; }
            set { _doccreated = value; Doc_Creat.Text = value; }
        }
        private void Doc_Edit_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void Doc_Del_Click(object sender, EventArgs e)
        {
            TwoSelect?.Invoke(this, e);
        }
        private void DoctorWidget_Load(object sender, EventArgs e)
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
