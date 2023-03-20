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
    public partial class DocOrdPatWidget : UserControl
    {
        public DocOrdPatWidget()
        {
            InitializeComponent();
        }
        private string _cardid,_namepat,_namedoc,_emadoc,_odate,_otime;
        public string OrderPCard
        {
            get { return _cardid; }
            set { _cardid = value; C_ID.Text = value; }
        }
        public string OrderPName
        {
            get { return _namepat; }
            set { _namepat = value; PAT_NAME.Text = value; }
        }
        public string OrderDDoc
        {
            get { return _namedoc; }
            set { _namedoc = value; DOC_NAME.Text = value; }
        }
        public string OrderDMail
        {
            get { return _emadoc; }
            set { _emadoc = value; DOC_MAIL.Text = value; }
        }
        public string OrderPDate
        {
            get { return _odate; }
            set { _odate = value; ORD_DATE.Text = value; }
        }
        public string OrderPTime
        {
            get { return _otime; }
            set { _otime = value; ORD_TIME.Text = value; }
        }
        private void DocOrdPatWidget_Load(object sender, EventArgs e)
        {

        }

        private void Colo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 50, 52);
        }

        private void Colo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }
    }
}
