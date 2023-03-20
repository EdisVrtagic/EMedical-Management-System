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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }
        //Database connection
        static string con = ConfigurationManager.ConnectionStrings["MEDC"].ConnectionString;
        SqlConnection Con = new SqlConnection(con);
        //Load administrator info
        public static string docrole;
        public static string iddoc;
        public static string idpat;
        string imgLoc = "";
        string patdoctor = "None";
        string patdoctoremail = "None";
        //Variables date created profile
        public static string profilecreated;
        //Dashboard load
        private void MedDash_Load(object sender, EventArgs e)
        {
            getDocData();
            getInfoData();
            VisibleComponents();
        }
        //Visible components
        private void VisibleComponents()
        {
            DynLabel.Text = "Dashboard";
            CustNotif.Location = new Point(1168, 763);
            addDocPanel.Location = new Point(690, 112);
            addPatPanel.Location = new Point(690, 76);
            editPatAssPanel.Location = new Point(690, 112);
            editDocPanel.Location = new Point(690, 112);
            InfoDocPanel.Location = new Point(344, 89);
            InfoPatPanel.Location = new Point(268, 89);
            DocLayoutPanel1.Location = new Point(341, 127);
            PatLayoutPanel1.Location = new Point(265, 127);
            searchDoc.Location = new Point(344, 50);
            searchPat.Location = new Point(268, 50);
            DocProfileAddBtn.Location = new Point(1289, 50);
            PatProfileAddBtn.Location = new Point(1360, 50);
            addDocPanel.Hide();
            addPatPanel.Hide();
            editDocPanel.Hide();
            InfoDocPanel.Hide();
            InfoPatPanel.Hide();
            DocLayoutPanel1.Hide();
            PatLayoutPanel1.Hide();
            searchPat.Hide();
            searchDoc.Hide();
            DocProfileAddBtn.Hide();
            PatProfileAddBtn.Hide();
            editPatAssPanel.Hide();
            DynamicDocControl();
            DynamicPatControl();
            CustNotif.Hide();
        }
        //Info Data
        private void getInfoData()
        {
            SqlDataAdapter sdt3 = new SqlDataAdapter("select count(*) from DoctorsTbl", Con);
            DataTable dr3 = new DataTable();
            sdt3.Fill(dr3);
            EmplLabel.Text = dr3.Rows[0][0].ToString();

            SqlDataAdapter sdt4 = new SqlDataAdapter("select count (Role_Doc) from DoctorsTbl where Role_Doc = 'administrator'", Con);
            DataTable dr4 = new DataTable();
            sdt4.Fill(dr4);
            totaladmin.Text = dr4.Rows[0][0].ToString();

            SqlDataAdapter sdt5 = new SqlDataAdapter("select count (Role_Doc) from DoctorsTbl where Role_Doc = 'doctor'", Con);
            DataTable dr5 = new DataTable();
            sdt5.Fill(dr5);
            totaldoc.Text = dr5.Rows[0][0].ToString();

            SqlDataAdapter sdt6 = new SqlDataAdapter("select count (Role_Doc) from DoctorsTbl where Role_Doc = 'nurse'", Con);
            DataTable dr6 = new DataTable();
            sdt6.Fill(dr6);
            totalnurse.Text = dr6.Rows[0][0].ToString();

            SqlDataAdapter sdt7 = new SqlDataAdapter("select count(*) from PatientsTbl", Con);
            DataTable dr7 = new DataTable();
            sdt7.Fill(dr7);
            PatLabel.Text = dr7.Rows[0][0].ToString();

            SqlDataAdapter sdt8 = new SqlDataAdapter("select count(*) from OrdersPatTbl", Con);
            DataTable dr8 = new DataTable();
            sdt8.Fill(dr8);
            OrderLabel.Text = dr8.Rows[0][0].ToString();

            SqlDataAdapter sdt9 = new SqlDataAdapter("select count(*) from RecordsTbl", Con);
            DataTable dr9 = new DataTable();
            sdt9.Fill(dr9);
            RecordLabel.Text = dr9.Rows[0][0].ToString();

            SqlDataAdapter sdt10 = new SqlDataAdapter("select count(*) from MedFindTbl", Con);
            DataTable dr10 = new DataTable();
            sdt10.Fill(dr10);
            MedFindLabel.Text = dr10.Rows[0][0].ToString();
        }
            //Load info administrator
            private void getDocData()
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
        //Upload admin profile image
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
        //Create admin/nurse/doctor profile
        private void saveDocBtn_Click(object sender, EventArgs e)
        {
            if (Full_Name.Text == "" || Full_Email.Text == "" || Full_Address.Text == "" || Full_Username.Text == "" || Full_Pass.Text == "" || Full_Roles.SelectedIndex == -1 || Full_Gender.SelectedIndex == -1)
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
                byte[] imgs;
                Image image = Image.FromFile(@"..\..\NotifImage\defaultpic.png");
                ImageConverter converter = new ImageConverter();
                imgs = (byte[])converter.ConvertTo(image, typeof(byte[]));
                string querys = "select * from DoctorsTbl where Email_Doc ='" + Full_Email.Text + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a;
                a = ds.Tables[0].Rows.Count;
                if (a == 1)
                {
                    saveDocBtn.Enabled = false;
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\error.png");
                    CustNotif.Text = "Email already exists!";
                    guna2Transition1.ShowSync(CustNotif);
                    NotifTimer.Start();
                }
                else
                {
                    if (Full_Pass.Text.Length < 6 || Full_Pass.Text.Length > 50)
                    {
                        CustNotif.BringToFront();
                        CustNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                        CustNotif.Text = "Password min 6 and max 50 characters!";
                        guna2Transition1.ShowSync(CustNotif);
                        NotifTimer.Start();
                    }
                    else
                    {
                        profilecreated = DateTime.Now.ToString("dd\\/MM\\/yyyy HH:mm:ss");
                        string query = "insert into DoctorsTbl(Name_Doc,Email_Doc,Address_Doc,Username_Doc,Pass_Doc,Role_Doc,Gen_Doc,Img_Doc,Profile_Created)values('" + Full_Name.Text + "','" + Full_Email.Text + "','" + Full_Address.Text + "','" + Full_Username.Text + "','" + Full_Pass.Text + "','" + Full_Roles.SelectedItem.ToString() + "','" + Full_Gender.SelectedItem.ToString() + "',@imgs,'" + profilecreated + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.Add(new SqlParameter("@imgs", imgs));
                        cmd.ExecuteNonQuery();
                        saveDocBtn.Enabled = false;
                        CustNotif.BringToFront();
                        CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                        CustNotif.Text = "Profile successfully created.";
                        guna2Transition1.ShowSync(CustNotif);
                        NotifTimer.Start();
                        ResetDoctorData();
                        dashBtn.Enabled = true;
                        doctorBtn.Enabled = true;
                        patienBtn.Enabled = true;
                        Con.Close();
                    }
                }
                Con.Close();
            }
        }
        //Create patient profile
        private void savePatBtn_Click(object sender, EventArgs e)
        {
            if (P_Name.Text == "" || P_Phone.Text == "" || P_Card.Text == "" || P_Address.Text == "" || P_Dob.Text == "" || P_Gen.SelectedIndex == -1)
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
                string querys = "select * from PatientsTbl where Card_Pat ='" + P_Card.Text + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a;
                a = ds.Tables[0].Rows.Count;
                if (a == 1)
                {
                    saveDocBtn.Enabled = false;
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\error.png");
                    CustNotif.Text = "The patient document already exists!";
                    guna2Transition1.ShowSync(CustNotif);
                    NotifTimer.Start();
                }
                else
                {
                    profilecreated = DateTime.Now.ToString("dd\\/MM\\/yyyy HH:mm:ss");
                    string query = "insert into PatientsTbl values('" + P_Name.Text + "','" + P_Phone.Text + "','" + P_Card.Text + "','" + P_Address.Text + "','" + P_Dob.Text + "','" + P_Gen.SelectedItem.ToString() + "','" + patdoctor + "','" + patdoctoremail + "','" + profilecreated + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    savePatBtn.Enabled = false;
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                    CustNotif.Text = "Patient successfully created.";
                    guna2Transition1.ShowSync(CustNotif);
                    NotifTimer.Start();
                    ResetPat();
                    dashBtn.Enabled = true;
                    doctorBtn.Enabled = true;
                    patienBtn.Enabled = true;
                    Con.Close();
                }
                Con.Close();
            }
        }
        //Dynamic doctors control list
        public void DynamicDocControl()
        {
            DocLayoutPanel1.Controls.Clear();
            try
            {
                string query = "SELECT * FROM DoctorsTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DoctorWidget[] listDoc = new DoctorWidget[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listDoc[i] = new DoctorWidget();
                                MemoryStream ms = new MemoryStream((byte[])row["Img_Doc"]);
                                listDoc[i].DocImage = new Bitmap(ms);
                                listDoc[i].DocID = row["ID_Doc"].ToString();
                                listDoc[i].DocName = row["Name_Doc"].ToString();
                                listDoc[i].DocEmail = row["Email_Doc"].ToString();
                                listDoc[i].DocAddr = row["Address_Doc"].ToString();
                                listDoc[i].DocRole = row["Role_Doc"].ToString();
                                listDoc[i].DocGend = row["Gen_Doc"].ToString();
                                listDoc[i].DocCreated = row["Profile_Created"].ToString();
                                DocLayoutPanel1.Controls.Add(listDoc[i]);
                                listDoc[i].OnSelect += new EventHandler(this.EditControl_Click);
                                listDoc[i].TwoSelect += new EventHandler(this.DeleteControl_Click);
                            }
                        }
                    }
                }
            }
            catch
            {
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
                                listPat[i].PatCard = row["Card_Pat"].ToString();
                                listPat[i].PatName = row["Name_Pat"].ToString();
                                listPat[i].PatPhone = row["Phone_Pat"].ToString();
                                listPat[i].PatAddress = row["Address_Pat"].ToString();
                                listPat[i].PatDOB= row["DOB_Pat"].ToString();
                                listPat[i].PatGender = row["Gender_Pat"].ToString();
                                listPat[i].PatDoctor = row["Doctor_Pat"].ToString();
                                listPat[i].PatCreated = row["Created_Pat"].ToString();
                                PatLayoutPanel1.Controls.Add(listPat[i]);
                                listPat[i].OnSelect += new EventHandler(this.EditPatControl_Click);
                                listPat[i].TwoSelect += new EventHandler(this.DeletePatControl_Click);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        //Edit patients in database
        void EditPatControl_Click(object sender, EventArgs es)
        {
            PatientWidget obje = (PatientWidget)sender;
            Pat_Ass.Text = obje.PatName;
            Pat_CAss.Text = obje.PatCard;
            idpat = obje.PatCard;
            SqlCommand cmd = new SqlCommand("select Email_Doc,Name_Doc from DoctorsTbl where Role_Doc = 'doctor'", Con);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            DataTable dtable = new DataTable();
            dap.Fill(dtable);
            ListDocAss.DataSource = dtable;
            ListDocAss.DisplayMember = "Name_Doc";
            ListDocAss.ValueMember = "Email_Doc";
            DynLabel.Text = "";
            HidePat();
            dashBtn.Enabled = false;
            doctorBtn.Enabled = false;
            patienBtn.Enabled = false;
            editPatAssPanel.Show();
        }
        //Doctor selected
        private void ListDocAss_SelectedValueChanged(object sender, EventArgs e)
        {
            Doc_AssEmail.Text = ListDocAss.SelectedValue.ToString();
            Doc_Ass.Text = ListDocAss.Text;
        }
        //Delete patients in database
        void DeletePatControl_Click(object sender, EventArgs ess)
        {
            try
            {
                PatientWidget obj = (PatientWidget)sender;
                idpat = obj.PatCard;
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PatientsTbl where Card_Pat='" + idpat + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string query = "delete from PatientsTbl where Card_Pat='" + idpat + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DynamicPatControl();
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                    CustNotif.Text = "Patient successfully deleted.";
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
        //Delete doctors in database
        void DeleteControl_Click(object sender, EventArgs ess)
        {
            try
            {
                DoctorWidget obj = (DoctorWidget)sender;
                iddoc = obj.DocID;
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorsTbl where ID_Doc='" + iddoc + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string query = "delete from DoctorsTbl where ID_Doc='" + iddoc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DynamicDocControl();
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                    CustNotif.Text = "Profile successfully deleted.";
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
        //Edit doctors in database
        void EditControl_Click(object sender, EventArgs es)
        {
            DoctorWidget obje = (DoctorWidget)sender;
            iddoc = obje.DocID;
            editDocName.Text = obje.DocName;
            editDocEmail.Text = obje.DocEmail;
            editDocAddress.Text = obje.DocAddr;
            editDocRole.SelectedItem = obje.DocRole;
            DynLabel.Text = "";
            HideDoc();
            dashBtn.Enabled = false;
            doctorBtn.Enabled = false;
            patienBtn.Enabled = false;
            editDocPanel.Show();
        }
        //Save edit admin/nurse/doctor profile
        private void saveEditDocBtn_Click(object sender, EventArgs e)
        {
            if (editDocName.Text == "" || editDocEmail.Text == "" || editDocAddress.Text == "" || editDocRole.SelectedIndex == -1)
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
                    string query = "update DoctorsTbl set Name_Doc ='" + editDocName.Text + "', Email_Doc= '" + editDocEmail.Text + "', Address_Doc = '" + editDocAddress.Text + "', Role_Doc = '" + editDocRole.SelectedItem.ToString() + "' where ID_Doc = '" + iddoc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    saveEditDocBtn.Enabled = false;
                    CustNotif.BringToFront();
                    CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                    CustNotif.Text = "Profile successfully edited.";
                    guna2Transition1.ShowSync(CustNotif);
                    NotifTimer.Start();
                    ResetEditDoc();
                    editDocPanel.Hide();
                    ShowDoc();
                    dashBtn.Enabled = true;
                    doctorBtn.Enabled = true;
                    patienBtn.Enabled = true;
                }
                catch
                {
                }
            }
            Con.Close();
        }
        //Assigning patients to doctors
        private void saveAssDocBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "update PatientsTbl set Doctor_Pat ='" + Doc_Ass.Text + "', DocPat_Email= '" + Doc_AssEmail.Text + "' where Card_Pat = '" + idpat + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                saveAssDocBtn.Enabled = false;
                CustNotif.BringToFront();
                CustNotif.Image = Image.FromFile(@"..\..\NotifImage\success.png");
                CustNotif.Text = "Patient successfully edited.";
                guna2Transition1.ShowSync(CustNotif);
                NotifTimer.Start();
                Pat_Ass.Text = "";
                Pat_CAss.Text = "";
                Doc_Ass.Text = "";
                Doc_AssEmail.Text = "";
                editPatAssPanel.Hide();
                ShowPat();
                dashBtn.Enabled = true;
                doctorBtn.Enabled = true;
                patienBtn.Enabled = true;
            }
            catch
            {
            }
            Con.Close();
        }
        //Reset add doctor
        private void ResetDoctorData()
        {
            Full_Name.Text = "";
            Full_Email.Text = "";
            Full_Address.Text = "";
            Full_Username.Text = "";
            Full_Pass.Text = "";
            Full_Roles.SelectedIndex = -1;
            Full_Gender.SelectedIndex = -1;
            addDocPanel.Hide();
            searchDoc.Show();
            DocProfileAddBtn.Show();
            InfoDocPanel.Show();
            DynamicDocControl();
            DocLayoutPanel1.Show();
        }
        //Reset add patient
        private void ResetPat()
        {
            P_Name.Text = "";
            P_Phone.Text = "";
            P_Card.Text = "";
            P_Address.Text = "";
            P_Dob.Text = "";
            P_Gen.SelectedIndex = -1;
            addPatPanel.Hide();
            searchPat.Show();
            PatProfileAddBtn.Show();
            InfoPatPanel.Show();
            DynamicPatControl();
            PatLayoutPanel1.Show();
        }
        //Hide Docs
        private void HideDoc()
        {
            InfoDocPanel.Hide();
            DocLayoutPanel1.Hide();
            searchDoc.Hide();
            DocProfileAddBtn.Hide();
        }
        //Hide Patients
        private void HidePat()
        {
            InfoPatPanel.Hide();
            PatLayoutPanel1.Hide();
            searchPat.Hide();
            PatProfileAddBtn.Hide();
        }
        //Show Docs
        private void ShowDoc()
        {
            DynamicDocControl();
            InfoDocPanel.Show();
            DocLayoutPanel1.Show();
            searchDoc.Show();
            DocProfileAddBtn.Show();
        }
        //Show Patients
        private void ShowPat()
        {
            DynamicPatControl();
            InfoPatPanel.Show();
            PatLayoutPanel1.Show();
            searchPat.Show();
            PatProfileAddBtn.Show();
        }
        //Add button doctors
        private void DocProfileAddBtn_Click(object sender, EventArgs e)
        {
            addDocPanel.Show();
            addPatPanel.Hide();
            InfoDocPanel.Hide();
            DocLayoutPanel1.Hide();
            searchDoc.Hide();
            DocProfileAddBtn.Hide();
            dashBtn.Enabled = false;
            doctorBtn.Enabled = false;
            patienBtn.Enabled = false;
        }
        //Reset edit doctor data
        private void ResetEditDoc()
        {
            editDocName.Text = "";
            editDocEmail.Text = "";
            editDocAddress.Text = "";
            editDocRole.SelectedIndex = -1;
        }
        //Search doc name
        private void searchDoc_TextChanged(object sender, EventArgs e)
        {
            foreach (var infodoc in DocLayoutPanel1.Controls)
            {
                var wdg = (DoctorWidget)infodoc;
                wdg.Visible = wdg.DocName.ToLower().ToLower().Contains(searchDoc.Text.Trim().ToLower());
            }
        }
        //Search pat id card
        private void searchPat_TextChanged(object sender, EventArgs e)
        {
            foreach (var infopat in PatLayoutPanel1.Controls)
            {
                var wdgs = (PatientWidget)infopat;
                wdgs.Visible = wdgs.PatCard.ToLower().ToLower().Contains(searchPat.Text.Trim().ToLower());
            }
        }
        //Close add doctor panel
        private void closeDocBtn_Click(object sender, EventArgs e)
        {
            addDocPanel.Hide();
            searchDoc.Show();
            DocProfileAddBtn.Show();
            InfoDocPanel.Show();
            DynamicDocControl();
            DocLayoutPanel1.Show();
            dashBtn.Enabled = true;
            doctorBtn.Enabled = true;
            patienBtn.Enabled = true;
        }
        //Close add patient panel
        private void closePatBtn_Click(object sender, EventArgs e)
        {
            addPatPanel.Hide();
            searchPat.Show();
            PatProfileAddBtn.Show();
            InfoPatPanel.Show();
            DynamicPatControl();
            PatLayoutPanel1.Show();
            dashBtn.Enabled = true;
            doctorBtn.Enabled = true;
            patienBtn.Enabled = true;
        }
        //Logout button
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }
        //Close application button
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Doctors list button
        private void doctorBtn_Click(object sender, EventArgs e)
        {
            DynLabel.Location = new Point(344, 9);
            DynLabel.Text = "Administrators,nurses and doctors";
            DataPanels.Hide();
            HidePat();
            ShowDoc();
        }
        //Dashboard button
        private void dashBtn_Click(object sender, EventArgs e)
        {
            DynLabel.Location = new Point(279, 9);
            DynLabel.Text = "Dashboard";
            HideDoc();
            HidePat();
            DataPanels.Show();
        }
        //Patients list button
        private void patienBtn_Click(object sender, EventArgs e)
        {
            DynLabel.Location = new Point(268, 9);
            DynLabel.Text = "Patients";
            DataPanels.Hide();
            HideDoc();
            ShowPat();
        }
        //Close edit doctor button
        private void closeEditDocBtn_Click(object sender, EventArgs e)
        {
            DynLabel.Location = new Point(344, 9);
            DynLabel.Text = "Administrators,nurses and doctors";
            dashBtn.Enabled = true;
            doctorBtn.Enabled = true;
            patienBtn.Enabled = true;
            editDocPanel.Hide();
            ResetEditDoc();
            ShowDoc();
        }
        //Close edit patient button
        private void closeAssBtn_Click(object sender, EventArgs e)
        {
            editPatAssPanel.Hide();
            searchPat.Show();
            PatProfileAddBtn.Show();
            InfoPatPanel.Show();
            DynamicPatControl();
            PatLayoutPanel1.Show();
            dashBtn.Enabled = true;
            doctorBtn.Enabled = true;
            patienBtn.Enabled = true;
        }
        //Add patient button
        private void PatProfileAddBtn_Click(object sender, EventArgs e)
        {
            addPatPanel.Show();
            addDocPanel.Hide();
            InfoPatPanel.Hide();
            PatLayoutPanel1.Hide();
            searchPat.Hide();
            PatProfileAddBtn.Hide();
            dashBtn.Enabled = false;
            doctorBtn.Enabled = false;
            patienBtn.Enabled = false;
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
        //Notification timer
        private void NotifTimer_Tick(object sender, EventArgs e)
        {
            if (NotifTimer.Interval == 500)
            {
                guna2Transition1.HideSync(CustNotif);
                NotifTimer.Stop();
                saveDocBtn.Enabled = true;
                savePatBtn.Enabled = true;
                saveEditDocBtn.Enabled = true;
                saveAssDocBtn.Enabled = true;
            }
        }
    }
  }
