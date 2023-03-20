using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace EMedical
{
    public partial class DoctorDash : Form
    {
        public DoctorDash()
        {
            InitializeComponent();
        }
        //Database connection
        static string con = ConfigurationManager.ConnectionStrings["MEDC"].ConnectionString;
        SqlConnection Con = new SqlConnection(con);
        public static string docrole;
        public static string docemail1;
        public static string medfindcreated;
        public static string findtext;
        string imgLoc = "";
        int datasaved = 0;
        private void DoctorDash_Load(object sender, EventArgs e)
        {
            getDocData();
            VisibleComponents();
        }
        //Visible components
        private void VisibleComponents()
        {
            CustNotif.Location = new Point(1168, 763);
            CustNotif.Hide();
            InfoPatPanel.Location = new Point(268, 89);
            PatLayoutPanel1.Location = new Point(265, 127);
            InfoOrdPanel.Location = new Point(430, 132);
            OrdLayoutPanel.Location = new Point(428, 172);
            searchPat.Location = new Point(1223, 50);
            finPatInfoPanel.Location = new Point(519, 91);
            dateOrderDoc.Location = new Point(1046, 89);
            MedFLayoutPanel.Location = new Point(293, 112);
            searchMedFind.Location = new Point(704, 21);
            SearchFindBtn.Location = new Point(930, 21);
            searchMedFind.Hide();
            SearchFindBtn.Hide();
            MedFLayoutPanel.Hide();
            dateOrderDoc.Hide();
            OrdLayoutPanel.Hide();
            InfoOrdPanel.Hide();
            DynamicPatControl();
            DynamicOrdControl();
            finPatInfoPanel.Hide();
        }
        //Load info doctor
        private void getDocData()
        {
            try
            {
                Con.Open();
                string querys = "select Name_Doc,Role_Doc,Email_Doc,Img_Doc from DoctorsTbl where Username_Doc = '" + Login.docusername + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataReader reader = cmds.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Full_N.Text = reader[0].ToString();
                    Role_D.Text = "Role | " + reader[1].ToString();
                    docrole = reader[1].ToString();
                    docemail1 = reader[2].ToString();
                    byte[] img = (byte[])(reader[3]);
                    if (img == null)
                    {
                        DocPic.Image = null;
                        Con.Close();
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        DocPic.Image = Image.FromStream(ms);
                        Con.Close();
                    }
                }
                else
                {
                    Con.Close();
                }
            }
            catch
            {
                Con.Close();
            }
        }
        //Upload doctor profile image
        private void uplDocPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = opendlg.FileName.ToString();
                DocPic.ImageLocation = imgLoc;
                try
                {
                    byte[] images = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    images = br.ReadBytes((int)fs.Length);
                    Con.Open();
                    string query = "update DoctorsTbl set Img_Doc = @images where Username_Doc = '" + Login.docusername + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                catch
                {

                }
            }
        }
        //Dynamic patients control list
        public void DynamicPatControl()
        {
            PatLayoutPanel1.Controls.Clear();
            try
            {
                string query = "SELECT * FROM PatientsTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        PatientWidget[] listPat = new PatientWidget[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listPat[i] = new PatientWidget();
                                listPat[i].Pat_Del.Hide();
                                listPat[i].Pat_Edit.Location = new Point(1116, 8);
                                listPat[i].PatCard = row["Card_Pat"].ToString();
                                listPat[i].PatName = row["Name_Pat"].ToString();
                                listPat[i].PatPhone = row["Phone_Pat"].ToString();
                                listPat[i].PatAddress = row["Address_Pat"].ToString();
                                listPat[i].PatDOB = row["DOB_Pat"].ToString();
                                listPat[i].PatGender = row["Gender_Pat"].ToString();
                                listPat[i].PatDoctor = row["Doctor_Pat"].ToString();
                                listPat[i].PatCreated = row["Created_Pat"].ToString();
                                PatLayoutPanel1.Controls.Add(listPat[i]);
                                listPat[i].OnSelect += new EventHandler(this.EditPatControl_Click);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //Medical finding save patient
        void EditPatControl_Click(object sender, EventArgs es)
        {
            PatientWidget obje = (PatientWidget)sender;
            fin_IDCard.Text = obje.PatCard;
            fin_PatName.Text = obje.PatName;
            fin_DocName.Text = obje.PatDoctor;
            InfoPatPanel.Hide();
            PatLayoutPanel1.Hide();
            searchPat.Hide();
            patientsBtn.Enabled = false;
            appointBtn.Enabled = false;
            medfindBtn.Enabled = false;
            finPatInfoPanel.Show();
        }
        //Dynamic order patient
        public void DynamicOrdControl()
        {
            OrdLayoutPanel.Controls.Clear();
            try
            {
                string query = "SELECT * FROM OrdersPatTbl where Ord_DocEmail = '" + docemail1 + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DocOrdPatWidget[] listOrder = new DocOrdPatWidget[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listOrder[i] = new DocOrdPatWidget();
                                listOrder[i].OrderPCard = row["ID_OrdCard"].ToString();
                                listOrder[i].OrderPName = row["Ord_Pat"].ToString();
                                listOrder[i].OrderDDoc = row["Ord_Doc"].ToString();
                                listOrder[i].OrderDMail = row["Ord_DocEmail"].ToString();
                                listOrder[i].OrderPDate = row["Ord_Date"].ToString();
                                listOrder[i].OrderPTime = row["Ord_Time"].ToString();
                                OrdLayoutPanel.Controls.Add(listOrder[i]);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //Timer form opacity
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
        //Logout button
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }
        //Application close button
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Search patient list
        private void searchPat_TextChanged(object sender, EventArgs e)
        {
            foreach (var infopat in PatLayoutPanel1.Controls)
            {
                var wdgs = (PatientWidget)infopat;
                wdgs.Visible = wdgs.PatCard.ToLower().ToLower().Contains(searchPat.Text.Trim().ToLower());
            }
        }
        //Patient button list
        private void patientsBtn_Click(object sender, EventArgs e)
        {
            dateOrderDoc.Hide();
            InfoOrdPanel.Hide();
            OrdLayoutPanel.Hide();
            searchMedFind.Hide();
            SearchFindBtn.Hide();
            MedFLayoutPanel.Hide();
            InfoPatPanel.Show();
            PatLayoutPanel1.Show();
            searchPat.Show();
        }
        //Appointments button
        private void appointBtn_Click(object sender, EventArgs e)
        {
            InfoPatPanel.Hide();
            PatLayoutPanel1.Hide();
            searchPat.Hide();
            searchMedFind.Hide();
            SearchFindBtn.Hide();
            MedFLayoutPanel.Hide();
            dateOrderDoc.Show();
            InfoOrdPanel.Show();
            OrdLayoutPanel.Show();
        }
        //Medical finding button
        private void medfindBtn_Click(object sender, EventArgs e)
        {
            dateOrderDoc.Hide();
            InfoOrdPanel.Hide();
            OrdLayoutPanel.Hide();
            InfoPatPanel.Hide();
            PatLayoutPanel1.Hide();
            searchPat.Hide();
            searchMedFind.Show();
            SearchFindBtn.Show();
            MedFLayoutPanel.Show();
        }
        //Print medical find doc 1
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                e.Graphics.DrawImage(pictureBox2.Image, 360, 30, 100, 100);
                e.Graphics.DrawString("EMedical", new Font("Segoe UI Semibold", 14), Brushes.Black, 367, 130);
                e.Graphics.DrawString("**************************************** Medical report ****************************************", new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 160);
                e.Graphics.DrawString("ID Card: " + fin_IDCard.Text, new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 210);
                e.Graphics.DrawString("Patient: " + fin_PatName.Text, new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 240);
                e.Graphics.DrawString("Doctor: " + fin_DocName.Text, new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 270);
                e.Graphics.DrawString("Diagnosis: ", new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 330);
                e.Graphics.DrawString("Opinion: ", new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 540);
                e.Graphics.DrawString("_______________________________________________________", new Font("Segoe UI Semibold", 11), Brushes.Black, 420, 1000);
                e.Graphics.DrawString("Prim. dr " + fin_DocName.Text, new Font("Segoe Script", 11), Brushes.Black, 420, 990);
                e.Graphics.DrawString("Prim. dr " + fin_DocName.Text, new Font("Segoe UI Semibold", 11), Brushes.Black, 420, 1020);
                e.Graphics.DrawString("________________________________________________________________________________________________________________", new Font("Segoe UI Semibold", 11), Brushes.Black, 55, 1080);
                e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"), new Font("Segoe UI Semibold", 11), Brushes.Black, 55, 1100);
                e.Graphics.DrawString("1/1", new Font("Segoe UI Semibold", 11), Brushes.Black, 750, 1100);
                Font myFont = new Font("Segoe UI Semibold", 11);
                float x = 55, y = 360;
                float width = 730, height = 200;
                RectangleF drawRect = new RectangleF(x, y, width, height);
                e.Graphics.DrawString(fin_Diag.Text, myFont, Brushes.Black, drawRect);
                float x1 = 55, y1 = 570;
                float width1 = 730, height1 = 400;
                RectangleF drawRect1 = new RectangleF(x1, y1, width1, height1);
                e.Graphics.DrawString(fin_Opin.Text, myFont, Brushes.Black, drawRect1);
        }
        //Close find patient
        private void closeFinPatBtn_Click(object sender, EventArgs e)
        {
            finPatInfoPanel.Hide();
            InfoPatPanel.Show();
            PatLayoutPanel1.Show();
            searchPat.Show();
            patientsBtn.Enabled = true;
            appointBtn.Enabled = true;
            medfindBtn.Enabled = true;
            savefinBtn.Enabled = true;
            finprintBtn.Enabled = true;
            fin_IDCard.Text = "";
            fin_PatName.Text = "";
            fin_DocName.Text = "";
            fin_Diag.Text = "";
            fin_Opin.Text = "";
        }
        //Search order date
        private void dateOrderDoc_TextChanged(object sender, EventArgs e)
        {
            foreach (var infopat in OrdLayoutPanel.Controls)
            {
                var wdgs = (DocOrdPatWidget)infopat;
                wdgs.Visible = wdgs.OrderPDate.ToLower().ToLower().Contains(dateOrderDoc.Text.Trim().ToLower());
            }
        }
        //Save find patient button
        private void savefinBtn_Click(object sender, EventArgs e)
        {
            if (fin_Diag.Text == "" || fin_Opin.Text == "")
            {
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustNotif.Text = "Enter the requested information!";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
            }
            else
            {
                Con.Open();
                medfindcreated = DateTime.Now.ToString("dd\\/MM\\/yyyy HH:mm");
                string query = "insert into MedFindTbl values('" + fin_IDCard.Text + "','" + fin_PatName.Text + "','" + fin_DocName.Text + "','" + fin_Diag.Text + "','" + fin_Opin.Text + "','" + medfindcreated + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                savefinBtn.Enabled = false;
                finprintBtn.Enabled = false;
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                CustNotif.Text = "Medical finding successfully created.";
                datasaved = 1;
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
                Con.Close();
            }
            Con.Close();
        }
        //Dynamic medical finding
        public void DynamicPatFind()
        {
            MedFLayoutPanel.Controls.Clear();
            try
            {
                string query = "SELECT * FROM MedFindTbl where Find_Card= '" + searchMedFind.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        MedFindWidget[] listFind = new MedFindWidget[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listFind[i] = new MedFindWidget();
                                listFind[i].FindCard = row["Find_Card"].ToString();
                                listFind[i].FindPatient = row["Find_Patient"].ToString();
                                listFind[i].FindDoctor = row["Find_Doctor"].ToString();
                                listFind[i].FindDiagnosis = row["Find_Diagnosis"].ToString();
                                listFind[i].FindOpinion = row["Find_Opinion"].ToString();
                                listFind[i].FindCreated = row["Find_Created"].ToString();
                                MedFLayoutPanel.Controls.Add(listFind[i]);
                                listFind[i].Click += new EventHandler(this.MedFindP_Click);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //Medical finding
        void MedFindP_Click(object sender, EventArgs es)
        {
            MedFindWidget obje = (MedFindWidget)sender;
            fin_IDCard.Text = obje.FindCard;
            fin_PatName.Text = obje.FindPatient;
            fin_DocName.Text = obje.FindDoctor;
            fin_Diag.Text = obje.FindDiagnosis;
            fin_Opin.Text = obje.FindOpinion;
            findtext = obje.FindCreated;
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }
        //Print medical find doc 1
        private void finprintBtn_Click(object sender, EventArgs e)
        {
            if (datasaved == 0)
            {
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustNotif.Text = "You must save the data first!";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
            }
            else if (datasaved == 1)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                    datasaved = 0;
                }
            }
        }
        //Notification timer
        private void NotifTimer_Tick(object sender, EventArgs e)
        {
            if (NotifTimer.Interval == 500)
            {
                guna2Transition1.HideSync(CustNotif);
                NotifTimer.Stop();
                savefinBtn.Enabled = true;
                finprintBtn.Enabled = true;
            }
        }
        //Print medical find doc 2
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox2.Image, 360, 30, 100, 100);
            e.Graphics.DrawString("EMedical", new Font("Segoe UI Semibold", 14), Brushes.Black, 367, 130);
            e.Graphics.DrawString("**************************************** Medical report ****************************************", new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 160);
            e.Graphics.DrawString("ID Card: " + fin_IDCard.Text, new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 210);
            e.Graphics.DrawString("Patient: " + fin_PatName.Text, new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 240);
            e.Graphics.DrawString("Doctor: " + fin_DocName.Text, new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 270);
            e.Graphics.DrawString("Diagnosis: ", new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 330);
            e.Graphics.DrawString("Opinion: ", new Font("Segoe UI Semibold", 12), Brushes.Black, 55, 540);
            e.Graphics.DrawString("_______________________________________________________", new Font("Segoe UI Semibold", 11), Brushes.Black, 420, 1000);
            e.Graphics.DrawString("Prim. dr " + fin_DocName.Text, new Font("Segoe Script", 11), Brushes.Black, 420, 990);
            e.Graphics.DrawString("Prim. dr " + fin_DocName.Text, new Font("Segoe UI Semibold", 11), Brushes.Black, 420, 1020);
            e.Graphics.DrawString("________________________________________________________________________________________________________________", new Font("Segoe UI Semibold", 11), Brushes.Black, 55, 1080);
            e.Graphics.DrawString("Date: " + findtext, new Font("Segoe UI Semibold", 11), Brushes.Black, 55, 1100);
            e.Graphics.DrawString("1/1", new Font("Segoe UI Semibold", 11), Brushes.Black, 750, 1100);
            Font myFont = new Font("Segoe UI Semibold", 11);
            float x = 55, y = 360;
            float width = 730, height = 200;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            e.Graphics.DrawString(fin_Diag.Text, myFont, Brushes.Black, drawRect);
            float x1 = 55, y1 = 570;
            float width1 = 730, height1 = 400;
            RectangleF drawRect1 = new RectangleF(x1, y1, width1, height1);
            e.Graphics.DrawString(fin_Opin.Text, myFont, Brushes.Black, drawRect1);
        }
        //Search medical find button
        private void SearchFindBtn_Click(object sender, EventArgs e)
        {
            if(searchMedFind.Text == "")
            {
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustNotif.Text = "Enter the requested information!";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
            }
            else
            {
                DynamicPatFind();
            }
        }
    }
}
