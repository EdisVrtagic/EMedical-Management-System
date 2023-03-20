using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace EMedical
{
    public partial class NurseDash : Form
    {
        public NurseDash()
        {
            InitializeComponent();
        }
        //Database connection
        static string con = ConfigurationManager.ConnectionStrings["MEDC"].ConnectionString;
        SqlConnection Con = new SqlConnection(con);
        public static string docrole;
        string imgLoc = "";
        //Variables date created records and orders patient
        public static string reccreated;
        public static string idor;
        private void NurseDash_Load(object sender, EventArgs e)
        {
            getNurData();
            DocListData();
            VisibleComponents();
        }
        void VisibleComponents()
        {
            CustNotif.Location = new Point(1168, 763);
            CustNotif.Hide();
            searchPat.Location = new Point(690, 12);
            searchPatOrd.Location = new Point(690, 12);
            searchPatBtn.Location = new Point(909, 12);
            searchPatOrdBtn.Location = new Point(909, 12);
            InfoPatPanel.Location = new Point(506, 112);
            PatRecLayoutPanel.Location = new Point(321, 109);
            PatOrdLayoutPanel.Location = new Point(281, 70);
            RecInfoPat.Location = new Point(324, 70);
            RecInfoPat.Hide();
            PatRecLayoutPanel.Hide();
            PatOrdLayoutPanel.Hide();
            searchPatOrdBtn.Hide();
            searchPatOrd.Hide();
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
        //Load info nurse
        private void getNurData()
        {
            try
            {
                Con.Open();
                string querys = "select Name_Doc,Role_Doc,Img_Doc from DoctorsTbl where Username_Doc = '" + Login.docusername + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataReader reader = cmds.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Full_N.Text = reader[0].ToString();
                    Role_D.Text = "Role | " + reader[1].ToString();
                    docrole = reader[1].ToString();
                    byte[] img = (byte[])(reader[2]);
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
        //Upload nurse profile image
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
        //Search patient info
        private void searchPatBtn_Click(object sender, EventArgs e)
        {
            if (searchPat.Text == "")
            {
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustNotif.Text = "Enter the requested information!";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
            }
            else
            {
                try
                {
                    Con.Open();
                    string querys = "select Card_Pat,Name_Pat,Address_Pat,Gender_Pat,DOB_Pat,Doctor_Pat,DocPat_Email from PatientsTbl where Card_Pat = '" + searchPat.Text + "'";
                    SqlCommand cmds = new SqlCommand(querys, Con);
                    SqlDataReader reader = cmds.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                        CustNotif.Text = "Patient found at the base.";
                        guna2Transition1.ShowSync(CustNotif);
                        NotifTimer.Start();
                        PatC.Text = reader[0].ToString();
                        PatN.Text = reader[1].ToString();
                        PatAD.Text = reader[2].ToString();
                        PatGE.Text = reader[3].ToString();
                        PatDOB.Text = reader[4].ToString();
                        ChDoctor.Text = reader[5].ToString();
                        ChEmDoctor.Text = reader[6].ToString();
                        searchPat.Text = "";
                        Con.Close();
                    }
                    else
                    {
                        Con.Close();
                        ResetInfoPat();
                        CustNotif.Image = Image.FromFile(@"..\..\NotifImage\error.png");
                        CustNotif.Text = "The patient does not exist!";
                        guna2Transition1.ShowSync(CustNotif);
                        NotifTimer.Start();
                    }
                }
                catch
                {
                }
            }
        }
        //List doctors data
        private void DocListData()
        {
            SqlCommand cmd = new SqlCommand("select Email_Doc,Name_Doc from DoctorsTbl where Role_Doc = 'doctor'", Con);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            DataTable dtable = new DataTable();
            dap.Fill(dtable);
            DataRow docrow = dtable.NewRow();
            docrow[1] = "Select doctor";
            dtable.Rows.InsertAt(docrow, 0);
            ListDoc.DataSource = dtable;
            ListDoc.DisplayMember = "Name_Doc";
            ListDoc.ValueMember = "Email_Doc";
        }
        //Notification timer
        private void NotifTimer_Tick(object sender, EventArgs e)
        {
            if (NotifTimer.Interval == 500)
            {
                guna2Transition1.HideSync(CustNotif);
                NotifTimer.Stop();
                recidBtn.Enabled = true;
                ordBtn.Enabled = true;
            }
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
        //List doc selected value changed
        private void ListDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            DocEmail.Text = ListDoc.SelectedValue.ToString();
            DocName.Text = ListDoc.Text;
            if (DocName.Text == "Select doctor")
            {
                DocName.Text = "";
            }
        }
        //Reset ifno patient
        void ResetInfoPat()
        {
            PatC.Text = "";
            PatN.Text = "";
            PatAD.Text = "";
            PatGE.Text = "";
            PatDOB.Text = "";
            ChDoctor.Text = "";
            ChEmDoctor.Text = "";
            reasPat.Text = "";
            searchPat.Text = "";
            timeOrder.Text = "";
            ListDoc.SelectedIndex = 0;
            DocName.Text = "";
            DocEmail.Text = "";
        }
        //Close info patient button
        private void closeInfoPatBtn_Click(object sender, EventArgs e)
        {
            ResetInfoPat();
        }
        //Add record patient
        private void recidBtn_Click(object sender, EventArgs e)
        {
            if (PatC.Text == "" || PatN.Text == "" || PatAD.Text == "" || PatGE.Text == "" || PatDOB.Text == "" || reasPat.Text == "")
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
                reccreated = DateTime.Now.ToString("dd\\/MM\\/yyyy HH:mm:ss");
                string query = "insert into RecordsTbl values('" + PatC.Text + "','" + PatN.Text + "','" + PatAD.Text + "','" + PatGE.Text + "','" + PatDOB.Text + "','" + reasPat.Text + "','" + reccreated + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                recidBtn.Enabled = false;
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                CustNotif.Text = "Record successfully created.";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
                ResetInfoPat();
                Con.Close();
            }
        }
        //Patient record option button
        private void patienBtn_Click(object sender, EventArgs e)
        {
            searchPat.Location = new Point(730, 12);
            searchPat.Show();
            searchPatOrd.Hide();
            PatOrdLayoutPanel.Hide();
            searchPatOrdBtn.Hide();
            searchPatBtn.Hide();
            InfoPatPanel.Hide();
            RecInfoPat.Show();
            PatRecLayoutPanel.Show();
            DynamicPatRecord();
        }
        //Dynamic patients record
        public void DynamicPatRecord()
        {
            PatRecLayoutPanel.Controls.Clear();
            try
            {
                string query = "SELECT * FROM RecordsTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        PatRecordWidget[] listRecord = new PatRecordWidget[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listRecord[i] = new PatRecordWidget();
                                listRecord[i].RecCard = row["RCard_Pat"].ToString();
                                listRecord[i].RecName = row["RName_Pat"].ToString();
                                listRecord[i].RecDOB = row["RDOB_Pat"].ToString();
                                listRecord[i].RecGender = row["RGender_Pat"].ToString();
                                listRecord[i].RecReas = row["Reason_Pat"].ToString();
                                listRecord[i].RecCreated = row["Record_Created"].ToString();
                                PatRecLayoutPanel.Controls.Add(listRecord[i]);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //Dynamic patients orders
        public void DynamicPatOrder()
        {
            PatOrdLayoutPanel.Controls.Clear();
            try
            {
                string query = "SELECT * FROM OrdersPatTbl where ID_OrdCard = '" + searchPatOrd.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        PatOrdWidget[] listOrders = new PatOrdWidget[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listOrders[i] = new PatOrdWidget();
                                listOrders[i].IDOrd = row["ID_Ord"].ToString();
                                listOrders[i].IDCard = row["ID_OrdCard"].ToString();
                                listOrders[i].IDPat = row["Ord_Pat"].ToString();
                                listOrders[i].IDDocs = row["Ord_Doc"].ToString();
                                listOrders[i].IDEmail = row["Ord_DocEmail"].ToString();
                                listOrders[i].IDDate = row["Ord_Date"].ToString();
                                listOrders[i].IDTime = row["Ord_Time"].ToString();
                                PatOrdLayoutPanel.Controls.Add(listOrders[i]);
                                listOrders[i].OnSelect += new EventHandler(this.DelOrders_Click);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //Delete orders in database
        void DelOrders_Click(object sender, EventArgs ess)
        {
            try
            {
                PatOrdWidget obj = (PatOrdWidget)sender;
                idor = obj.IDOrd;
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OrdersPatTbl where ID_Ord='" + idor + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string query = "delete from OrdersPatTbl where ID_Ord='" + idor + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DynamicPatOrder();
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                    CustNotif.Text = "Record successfully deleted.";
                    guna2Transition1.ShowSync(CustNotif);
                    NotifTimer.Start();
                    Con.Close();
                }
            }
            catch
            {
            }
            Con.Close();
        }
        //Dashboard list patients button
        private void dashBtn_Click(object sender, EventArgs e)
        {
            searchPat.Location = new Point(690, 12);
            searchPat.Show();
            RecInfoPat.Hide();
            searchPatOrd.Hide();
            searchPatOrdBtn.Hide();
            PatRecLayoutPanel.Hide();
            PatOrdLayoutPanel.Hide();
            searchPatBtn.Show();
            InfoPatPanel.Show();
        }
        //Search patient
        private void searchPat_TextChanged(object sender, EventArgs e)
        {
            foreach (var record in PatRecLayoutPanel.Controls)
            {
                var wdg = (PatRecordWidget)record;
                wdg.Visible = wdg.RecCard.ToLower().ToLower().Contains(searchPat.Text.Trim().ToLower());
            }
        }
        //Order patient button
        private void ordBtn_Click(object sender, EventArgs e)
        {
            if (PatC.Text == "" || PatN.Text == "" || ListDoc.SelectedIndex == -1 || DocName.Text == "" || DocEmail.Text == "" || timeOrder.Text == "")
            {
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustNotif.Text = "Enter the requested information!";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
            }
            else
            {
                Con.Open();
                string query = "insert into OrdersPatTbl values('" + PatC.Text + "','" + PatN.Text + "','" + DocName.Text + "','" + DocEmail.Text + "','" + dateOrder.Value.ToShortDateString() + "','" + timeOrder.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                ordBtn.Enabled = false;
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                CustNotif.Text = "Patient successfully ordered.";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
                ResetInfoPat();
                Con.Close();
            }
        }
        //Order option button
        private void orderedBtn_Click(object sender, EventArgs e)
        {
            searchPat.Hide();
            searchPatBtn.Hide();
            searchPatOrd.Show();
            searchPatOrdBtn.Show();
            PatOrdLayoutPanel.Show();
        }
        //Seatch orderd patient button
        private void searchPatOrdBtn_Click(object sender, EventArgs e)
        {
            if(searchPatOrd.Text == "")
            {
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustNotif.Text = "Enter the requested information!";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
            }
            else
            {
                DynamicPatOrder();
            }
        }
    }
}
