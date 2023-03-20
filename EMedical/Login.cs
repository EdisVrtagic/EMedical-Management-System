using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace EMedical
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Database connection
        static string conect = ConfigurationManager.ConnectionStrings["MEDC"].ConnectionString;
        SqlConnection Con = new SqlConnection(conect);
        //Static string
        public static string docrole;
        public static string docusername;
        //Load data
        private void Login_Load(object sender, EventArgs e)
        {
            CustomNotif.Visible = false;
        }
        //Login button
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || PassBox.Text == "")
            {
                loginBtn.Enabled = false;
                CustomNotif.Image = Image.FromFile(@"..\..\NotifImage\warning.png");
                CustomNotif.Text = "Enter the requested information!";
                guna2Transition1.ShowSync(CustomNotif);
                NotTimer.Start();
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorsTbl where Username_Doc='" + NameBox.Text + "' and Pass_Doc='" + PassBox.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sdaa = new SqlDataAdapter("select Role_Doc from DoctorsTbl where Username_Doc='" + NameBox.Text + "' and Pass_Doc='" + PassBox.Text + "'", Con);
                    DataTable dtt = new DataTable();
                    sdaa.Fill(dtt);
                    docrole = dtt.Rows[0][0].ToString();
                    docusername = NameBox.Text;
                    if (docrole == "doctor")
                    {
                        this.Hide();
                        DoctorDash dds = new DoctorDash();
                        dds.Show();
                    }
                    else if (docrole == "administrator")
                    {
                        this.Hide();
                        AdminDash mds = new AdminDash();
                        mds.Show();
                    }
                    else if (docrole == "nurse")
                    {
                        this.Hide();
                        NurseDash nds = new NurseDash();
                        nds.Show();
                    }
                    Con.Close();
                }
                else
                {
                    loginBtn.Enabled = false;
                    CustomNotif.Image = Image.FromFile(@"..\..\NotifImage\error.png");
                    CustomNotif.Text = "Profile does not exist!";
                    guna2Transition1.ShowSync(CustomNotif);
                    NotTimer.Start();
                }
            }
            Con.Close();
        }
        //Application close button
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        //Custom notification timer
        private void NotTimer_Tick(object sender, EventArgs e)
        {
            if (NotTimer.Interval == 500)
            {
                guna2Transition1.HideSync(CustomNotif);
                NotTimer.Stop();
                loginBtn.Enabled = true;
            }
        }
        //Linkedin direct link profile
        private void lnBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/edis-vrtagic22/");
        }
        //YouTube direct link channel
        private void ytBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/DonMarquez21");
        }
        //GitHub direct link profile
        private void gitBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EdisVrtagic");
        }
    }
}
