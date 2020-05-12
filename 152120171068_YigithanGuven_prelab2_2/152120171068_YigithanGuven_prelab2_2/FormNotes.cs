using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }
        public List<notes> records = new List<notes>();

        private void Notes_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Functions.bingPathToAppDir("\\data\\notes.csv")))
            {
                System.IO.FileStream f = System.IO.File.Create(Functions.bingPathToAppDir("\\data\\notes.csv"));
                f.Close();
            }
            using (var reader = new StreamReader(Functions.bingPathToAppDir("\\data\\notes.csv")))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new notes   // we have one field for note, one field for note name,one field for current user
                    {
                        notename = csv.GetField("notename"),
                        note = csv.GetField("note"),
                        user = csv.GetField("user")
                    };
                    records.Add(record);
                }
            }
            listView1.Items.Clear();
            foreach (var person in records)
            {
                if (Login.CurrentUser.Username == person.user)
                {
                    var row = new string[] { person.notename, person.note, person.user };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = person;
                    listView1.Items.Add(lvi);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Organizer yeni = new Organizer();
            yeni.Show();
            this.Hide();
        }

        private void CreateNote_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && textBoxNoteName.Text != string.Empty)
            {
                listView1.Visible = true;
                var writeRecord = new notes
                {
                    notename = textBoxNoteName.Text,
                    note = comboBox1.Text,
                    user = Login.CurrentUser.Username
                };
                records.Add(writeRecord);
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\notes.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(records);
                }

                listView1.Items.Clear();
                foreach (var person in records)
                {
                    if (Login.CurrentUser.Username == person.user)
                    {
                        var row = new string[] { person.notename, person.note, person.user };
                        var lvi = new ListViewItem(row);
                        lvi.Tag = person;
                        listView1.Items.Add(lvi);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNote_Click(object sender, EventArgs e)
        {
            int NumberOfSelected = listView1.SelectedItems.Count;
            foreach (ListViewItem SelectedItems in listView1.SelectedItems)
            {
                int i = 0;
                SelectedItems.Remove();
                while (i < records.Count)
                {
                    if (records[i].notename == SelectedItems.Text)
                    {
                        records.RemoveAt(i);
                        using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\notes.csv")))
                        using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv2.WriteRecords(records);
                        }
                    }
                    i++;
                }
            }
            var writeRecord = new notes
            {
                notename = textBoxNoteName.Text,
                note = comboBox1.Text,
                user = Login.CurrentUser.Username
            };

            records.Add(writeRecord);
            using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\notes.csv")))
            using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv2.WriteRecords(records);
            }

            listView1.Items.Clear();
            foreach (var persons in records)
            {
                if (persons.user == Login.CurrentUser.Username)
                {
                    var row = new string[] { persons.notename, persons.note, persons.user };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = persons;
                    listView1.Items.Add(lvi);
                }
            }
        }
    
        private void DeleteNote_Click(object sender, EventArgs e)
        {
            int NumberOfSelected = listView1.SelectedItems.Count;
            foreach (ListViewItem SelectedItems in listView1.SelectedItems)
            {
                int i = 0;
                SelectedItems.Remove();
                while (i < records.Count)
                {
                    if (records[i].notename == SelectedItems.Text)
                    {
                        records.RemoveAt(i);
                        using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\notes.csv")))
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
                textBoxNoteName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void FormNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}
