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
    public partial class UserManagment : Form
    {
        public UserManagment()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_ChangeUserType_Click(object sender, EventArgs e)
        {
            bool UserError = true;

            for (int i = 0; i < Program.records.Count; i++)
            {
                if (Program.records[i].Username == tB_Username.Text)
                {
                    if (rB_Admin.Checked)
                    {
                        Program.records[i].UserType = "0";
                        UserError = false;
                        break;
                    }
                    else if(rB_User.Checked)
                    {
                        Program.records[i].UserType = "1";
                        UserError = false;
                        break;
                    }
                    else if (rB_PartTimeUser.Checked)
                    {
                        Program.records[i].UserType = "2";
                        UserError = false;
                        break;
                    }                    
                }
            }
            if (UserError==true)
            {
                MessageBox.Show("User Name Is Wrong Or You Didnt Cheked Any Radio Buttons");
            }
            else
            {
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\users.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(Program.records);
                }
                MessageBox.Show("User Type Was Changed");
            }
        }
        private void btn_goBack_Click(object sender, EventArgs e)
        {
            Menu1 form = new Menu1();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
        }

        private void UserManagment_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}
