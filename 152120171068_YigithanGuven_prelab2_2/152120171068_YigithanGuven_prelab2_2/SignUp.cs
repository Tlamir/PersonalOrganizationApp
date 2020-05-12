using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class SignUp : Form
    {
        private string base64String;

        public SignUp()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        //adding new user
        private void ClearAll()
        {
            tBnewusername.Clear();
            tbnewpassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Image image = Image.FromFile(Functions.bingPathToAppDir("\\data\\unnamed.png")))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    base64String = Convert.ToBase64String(imageBytes);
                }
            }

            bool uniqeusername = true;

            for (int i =0;i<Program.records.Count(); i++)
            {
                if (tBnewusername.Text==Program.records[i].Username)
                {
                    uniqeusername = false;
                    break;
                }
            }

            string usertype;
            if (tbnewpassword.Text.Length >= 8 && tbnewpassword.Text.Length <= 15)
            {
                if (tbnewpassword.Text != "" && tBnewusername.Text != "" && uniqeusername == true)
                {
                    if (Program.NoUser == true)
                    {
                        usertype = "0";
                    }
                    else
                    {
                        usertype = "1";
                    }
                    var record2 = new user
                    {
                        Username = tBnewusername.Text,
                        Password = Functions.ComputeSha256Hash(tbnewpassword.Text),
                        Photo = base64String,
                        UserType = usertype
                    };
                    Program.records.Add(record2);
                    using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\users.csv")))
                    using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv2.WriteRecords(Program.records);
                    }
                    Program.NoUser = false;
                    String message = "Account Was Created";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, "Log Out", buttons);
                    if (result == DialogResult.OK)
                    {
                        Login form = new Login();
                        form.Show();
                        form.FormClosing += (obj, args) => { this.Close(); };
                        this.Hide();
                    }
                }
                else
                {
                    string message = "Username already exists";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    ClearAll();
                }
            }
            else
                MessageBox.Show("Password must be between 8 - 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }
    }
}

