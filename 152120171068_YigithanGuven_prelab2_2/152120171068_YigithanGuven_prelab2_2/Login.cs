using CsvHelper;
using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class Login : Form
    {
        public void testc()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }
        Random random = new Random();
        public static string loginname;
        int countdwn = 3;
        int registerKey;
        string newpassword;
        string globalemail;
        private void timer_Tick(object sender, EventArgs e)
        {
            Countdown.Text = countdwn.ToString();
            if (countdwn == 0)
            {
                if (Flag == true)
                {
                    Menu1 form = new Menu1();
                    form.Show();
                    form.FormClosing += (obj, args) => { this.Close(); };
                    this.Hide();
                }     
            }
            countdwn--;
        }
        bool Flag = false;
        public Login()
        {
            InitializeComponent();
        }
        public List<user> recordsR = new List<user>();
        public static user CurrentUser = new user();
        public new user UserR = new user();

        private void button1_Click(object sender, EventArgs e)
        {
            loginname = tBname.Text;
            // write o remember file
            if (cB1.Checked)
            {
                UserR.Username = tBname.Text;
                UserR.Password = tBpassword.Text;
                UserR.UserType = "1";

                var recordR = new user
                {
                    Username = tBname.Text,
                    Password = Functions.ComputeSha256Hash(tBpassword.Text),
                    UserType = "1"
                };

                recordsR.Add(recordR);
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\RememberMe.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(recordsR);
                }
            }
            for (int i = 0; i < Program.records.Count; i++)
            {
                if (Program.records[i].Username == tBname.Text)
                {
                    if (Program.records[i].Password == Functions.ComputeSha256Hash(tBpassword.Text))
                    {
                        Flag = true;
                        CurrentUser.Username = Program.records[i].Username;
                        CurrentUser.Password = Program.records[i].Password;
                        CurrentUser.UserType = Program.records[i].UserType;
                        break;
                    }
                }
            }
            if (newpassword == txtRegisterCode.Text)
            {
                Menu1 yeni = new Menu1();
                yeni.Show();
                this.Hide();

                for (int i = 0; i < Program.records.Count; i++)
                {
                    if (Program.records[i].Username == tBname.Text)
                    {
                        Program.records[i].Password = newpassword;
                    }
                }
            }
            if (Flag == true)
            {
                lbFlag.ForeColor = System.Drawing.Color.Green;
                lbFlag.Text = "Sucsesfull Login";
                btnLgn.Enabled = false;
                btnSignup.Enabled = false;
                testc();
            }
            else
            {
                lbFlag.ForeColor = System.Drawing.Color.Red;
                lbFlag.Text = "Failed To Login";
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            //read remember csv
            using (var reader = new StreamReader(Functions.bingPathToAppDir("\\data\\RememberMe.csv")))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new user
                    {
                        Username = csv.GetField("Username"),
                        Password = csv.GetField("Password"),
                         UserType = csv.GetField("UserType")
                    };
                    UserR = record;
                } 
            }
            //re login if remember file includes info
            
            if (UserR.Password!=" " && UserR.Username!=" ")
            {
                tBname.Text = UserR.Username;
                tBpassword.Text =UserR.Password;
                for (int i = 0; i < Program.records.Count; i++)
                {
                    if (Program.records[i].Username == tBname.Text)
                    {
                        if (Program.records[i].Password == tBpassword.Text)
                        {
                            Flag = true;
                            CurrentUser.Username = Program.records[i].Username;
                            CurrentUser.Password = Program.records[i].Password;
                            CurrentUser.UserType = Program.records[i].UserType;
                            break;
                        }
                    }
                }
                if (Flag == true)
                {
                    lbFlag.ForeColor = System.Drawing.Color.Green;
                    cB1.Checked = true;
                    cB1.Enabled = false;
                    lbFlag.Text = "Sucsesfull Login";
                    testc();
                    btnLgn.Enabled = false;
                    btnSignup.Enabled = false;
                }
            }
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            if (tBname.Text == "")
            {
                lblusername.Visible = true;
            }
            else
            {
                lblusername.Visible = false;
                lblRegisterCode.Visible = true;
                lblVerificationCode.Visible = true;
                txtRegisterCode.Visible = true;

                for (int i = 0; i < Program.records.Count; i++)
                {
                    if (Program.records[i].Username == tBname.Text)
                    {
                        try
                        {
                            globalemail = Program.records[i].Email;
                            registerKey = random.Next(10000, 99999);

                            SmtpClient sc = new SmtpClient();
                            sc.Port = 587;
                            sc.Timeout = 50000;
                            sc.Host = "smtp.gmail.com";
                            sc.EnableSsl = true;
                            sc.Credentials = new NetworkCredential("nesnedeneme2020@gmail.com", "nesneoop");

                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("nesnedeneme2020@gmail.com", "Buket-Harun-Yigit");
                            mail.To.Add(globalemail);
                            mail.Subject = "New Password";
                            mail.IsBodyHtml = true;
                            mail.Body = "Your verification code to login: " + registerKey.ToString()+" (This is a temporary password. Set a new password from personalinformation part.)";
                          
                            sc.Send(mail);
                        }
                        catch
                        {
                            MessageBox.Show("Please check your email address and try again.\nIf the problem persists, try again after a while.");
                        }
                        newpassword = registerKey.ToString();
                    }
                }
            }
        }
    }
}