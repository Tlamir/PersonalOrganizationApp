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
    public partial class Menu1 : Form
    {
        public List<user> recordsRexit = new List<user>();
        public Menu1()
        {
            InitializeComponent();
        }
        int countdwn = 2;
        public void testc()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (countdwn == 0)
            {
                if (Flag == true)
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                }
            }
            countdwn--;
        }
        bool Flag = false;
        public List<calender> data = new List<calender>();
        private void Form2_Load(object sender, EventArgs e)
        {
            Flag = true;
            testc();
            if (!System.IO.File.Exists(Functions.bingPathToAppDir("\\data\\reminder.csv")))
            {
                System.IO.FileStream f = System.IO.File.Create(Functions.bingPathToAppDir("\\data\\reminder.csv"));
                f.Close();
            }
            // load recods from users csv file
            using (var reader = new StreamReader(Functions.bingPathToAppDir("\\data\\reminder.csv")))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new calender
                    {
                        username = csv.GetField("username"),
                        type = csv.GetField("type"),
                        note = csv.GetField("note"),
                        date = csv.GetField("date"),
                        clock = csv.GetField("clock")
                    };
                    data.Add(record);
                }
            }
            foreach (var person in data)
            {
                if (Login.CurrentUser.Username == person.username)
                {
                    pictureBox1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label2.Text = person.note;
                    label3.Text = person.date +"  " +person.clock;
                }
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            String message = "Do You Really Want to Log out?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", buttons);
            if (result == DialogResult.Yes)
            {
                // delete current remember me user
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\RememberMe.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(recordsRexit);
                }
                Login form = new Login();
                form.Show();
                form.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
            }
        }
        private void btntsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "tsv file|*.tsv";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                for (int i = 0; i < Program.records.Count; i++)
                {
                    string line = Program.records[i].Username + "\t" + Program.records[i].Password;
                    Kayit.WriteLine(line);
                    Kayit.Flush();
                }
                MessageBox.Show("User List Have Been Exported");

                Kayit.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.CurrentUser.UserType=="0")
            {
                UserManagment form = new UserManagment();
                form.Show();
                form.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
            }
            else
            {
                MessageBox.Show("Only Admin Can Manage Users");
            }
        }
        private void btn_organizer_Click(object sender, EventArgs e)
        {
            Organizer org = new Organizer();
            org.Show();
            this.Hide();
        }

        private void Menu1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}
