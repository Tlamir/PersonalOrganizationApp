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
using System.Globalization;
using CsvHelper;
using System.Text.RegularExpressions;

namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class FormPhoneBook : Form
    {
        public FormPhoneBook()
        {
            InitializeComponent();
        }
        public List<phonebook> records = new List<phonebook>();
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void FormPhoneBook_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Functions.bingPathToAppDir("\\data\\phonebook.csv")))
            {
                System.IO.FileStream f = System.IO.File.Create(Functions.bingPathToAppDir("\\data\\phonebook.csv"));
                f.Close();
            }
            // load recods from users csv file
            using (var reader = new StreamReader(Functions.bingPathToAppDir("\\data\\phonebook.csv")))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new phonebook
                    {
                        name = csv.GetField("name"),
                        surname = csv.GetField("surname"),
                        phonenumber = csv.GetField("phonenumber"),
                        address = csv.GetField("address"),
                        description = csv.GetField("description"),
                        email = csv.GetField("email"),
                        user = csv.GetField("user")
                    };
                    records.Add(record);
                }
            }
            listView1.Items.Clear();
            foreach (var person in records)
            {
                if(Login.CurrentUser.Username==person.user)
                {
                    var row = new string[] { person.name, person.surname, person.phonenumber, person.address, person.description, person.email };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = person;
                    listView1.Items.Add(lvi);
                }
            }
        }
        private void CreateRecord_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                var writeRecord = new phonebook
                {
                    name = textBoxName.Text,
                    surname = textBoxSurname.Text,
                    phonenumber = maskedTextBoxNumber.Text,
                    address = textBoxAddress.Text,
                    description = textBoxDescription.Text,
                    email = textBoxEmail.Text,
                    user = Login.CurrentUser.Username
                };
                records.Add(writeRecord);
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\phonebook.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(records);
                }

                listView1.Items.Clear();
                foreach (var person in records)
                {
                    if (Login.CurrentUser.Username == person.user)
                    {
                        var row = new string[] { person.name, person.surname, person.phonenumber, person.address, person.description, person.email };
                        var lvi = new ListViewItem(row);

                        lvi.Tag = person;
                        listView1.Items.Add(lvi);
                    }
                }
            }
            else
                MessageBox.Show("Enter Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Organizer yeni = new Organizer();
            yeni.Show();
            this.Hide();
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateRecord.Enabled = true;
            DeleteRecord.Enabled = true;
            if (listView1.SelectedItems.Count > 0)
            {
                textBoxName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxSurname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                maskedTextBoxNumber.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBoxAddress.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBoxDescription.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBoxEmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            //here is the problem add ! in font 

            if (!String.IsNullOrWhiteSpace(textBoxName.Text)) // This will prevent exception when textbox is empty   
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxName.Text, "^[a-zA-ZğüşöçİĞÜŞÖÇ]+$"))
                {
                    MessageBox.Show("Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxName.Text.Remove(textBoxName.Text.Length - 1);
                    textBoxName.Clear();
                    textBoxName.Focus();
                }
            }
        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            //here is the problem add ! in font 
            if (!String.IsNullOrWhiteSpace(textBoxSurname.Text)) // This will prevent exception when textbox is empty   
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSurname.Text, "^[a-zA-ZğüşöçİĞÜŞÖÇ]"))
                {
                    MessageBox.Show("Enter Valid Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSurname.Text.Remove(textBoxSurname.Text.Length - 1);
                    textBoxSurname.Clear();
                    textBoxSurname.Focus();
                }
            }
        }
        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            int NumberOfSelected = listView1.SelectedItems.Count;
            foreach (ListViewItem SelectedItems in listView1.SelectedItems)
            {
                int i = 0;
                SelectedItems.Remove();
                while (i < records.Count)
                {
                    if (records[i].name == SelectedItems.Text)
                    {
                        records.RemoveAt(i);
                        using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\phonebook.csv")))
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
        //Listview'den bir satır seçildiği zaman update butonu aktif olur ve değişiklik yapıp kaydedebilirsin.
        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            int NumberOfSelected = listView1.SelectedItems.Count;
            foreach (ListViewItem SelectedItems in listView1.SelectedItems)
            {
                int i = 0;
                SelectedItems.Remove();
                while (i < records.Count)
                {
                    if (records[i].name == SelectedItems.Text)
                    {
                        records.RemoveAt(i);
                        using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\phonebook.csv")))
                        using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv2.WriteRecords(records);
                        }
                    }
                    i++;
                }
            }
            string email = textBoxEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                var writeRecord = new phonebook
                {
                    name = textBoxName.Text,
                    surname = textBoxSurname.Text,
                    phonenumber = maskedTextBoxNumber.Text,
                    address = textBoxAddress.Text,
                    description = textBoxDescription.Text,
                    email = textBoxEmail.Text
                };

                records.Add(writeRecord);
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\phonebook.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(records);
                }

                listView1.Items.Clear();
                foreach (var person in records)
                {
                    var row = new string[] { person.name, person.surname, person.phonenumber, person.address, person.description, person.email };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = person;
                    listView1.Items.Add(lvi);
                }
            }
            else
                MessageBox.Show("Enter Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormPhoneBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(1);
        }
    }
}
