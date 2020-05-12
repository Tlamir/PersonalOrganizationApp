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
using CsvHelper;


namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class FormCleander : Form
    {
        public FormCleander()
        {
            InitializeComponent();
        }

        public List<calender> records = new List<calender>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            if (!System.IO.File.Exists(Functions.bingPathToAppDir("\\data\\reminder.csv")))
            {
                System.IO.FileStream f = System.IO.File.Create(Functions.bingPathToAppDir("\\data\\reminder.csv"));
                f.Close();
            }
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
                    records.Add(record);
                }
            }
            listView1.Items.Clear();
            foreach (var person in records)
            {
                if (Login.CurrentUser.Username == person.username)
                {
                    var row = new string[] { person.type, person.note, person.date, person.clock};
                    var lvi = new ListViewItem(row);

                    lvi.Tag = person;
                    listView1.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value;
            string format = "d MMM yyyy";//gün ay yıl şeklinde csv'de tutmak için bu formata çevrildi. 
            string a = tarih.ToString(format);

            DateTime saat = dateTimePicker2.Value;
            string format1 = "HH:mm"; // Saat formatın doğru olması için. 
            string b = saat.ToString(format1);
            if (comboBox1.Text != string.Empty && txtNote.Text != string.Empty)
            {
                var writeRecord = new calender
                {
                    username = Login.CurrentUser.Username,
                    type = comboBox1.Text,
                    note = txtNote.Text,
                    date = a,
                    clock = b
                };
                records.Add(writeRecord);
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\reminder.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(records);
                }

                listView1.Items.Clear();
                foreach (var person in records)
                {
                    if (Login.CurrentUser.Username == person.username)
                    {
                        var row = new string[] { person.type, person.note, person.date, person.clock };
                        var lvi = new ListViewItem(row);
                        lvi.Tag = person;
                        listView1.Items.Add(lvi);
                    }
                }

                MessageBox.Show("Reminder Added");
            }
            else
            {
                MessageBox.Show("Please fill in the empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Organizer yeni = new Organizer();
            yeni.Show();
            this.Hide();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value;
            string format = "d MMM yyyy";//tarihe uygulanacak format
            string a = tarih.ToString(format);

            DateTime saat = dateTimePicker2.Value;
            string format1 = "HH:mm";
            string b = saat.ToString(format1);

            int NumberOfSelected = listView1.SelectedItems.Count;
            foreach (ListViewItem SelectedItems in listView1.SelectedItems)
            {
                int i = 0;
                SelectedItems.Remove();
                while (i < records.Count)
                {
                    if (records[i].note == SelectedItems.Text)
                    {
                        records.RemoveAt(i);
                        using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\reminder.csv")))
                        using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv2.WriteRecords(records);
                        }
                    }
                    i++;
                }
            }
            var writeRecord = new calender
            {
                username = Login.CurrentUser.Username,
                type = comboBox1.Text,
                note = txtNote.Text,
                date = a,
                clock = b
            };

            records.Add(writeRecord);
            using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\reminder.csv")))
            using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv2.WriteRecords(records);
            }

            listView1.Items.Clear();
            foreach (var person in records)
            {
                if (person.username == Login.CurrentUser.Username)
                {
                    var row = new string[] {person.type, person.note, person.date, person.clock };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = person;
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int NumberOfSelected = listView1.SelectedItems.Count;
            foreach (ListViewItem SelectedItems in listView1.SelectedItems)
            {
                int i = 0;
                SelectedItems.Remove();
                while (i < records.Count)
                {
                    if (records[i].note == SelectedItems.Text)
                    {
                        records.RemoveAt(i);
                        using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\reminder.csv")))
                        using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv2.WriteRecords(records);
                        }
                    }
                    i++;
                }
            }
            MessageBox.Show(NumberOfSelected.ToString() + " Record Was Deleted.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                comboBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtNote.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void FormCleander_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}