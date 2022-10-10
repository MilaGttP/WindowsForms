
namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        // First Task Tab
        Person person = null;
        private void SelectedTabIndex(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                person = new Person();
                this.ActiveControl = SurnameTB;
                // adding inf to comboboxes
                PositionCB.Items.AddRange(new string[] { "Average coworker", "Manager", "Director" });
                CityCB.Items.AddRange(new string[] { "Vinnitsya", "Kyiv", "Kharkiv" });
                StreetCB.Items.AddRange(new string[] { "Kyivska", "Soborna", "Pyrohova" });
                HouseCB.Items.AddRange(new object[] { 22, 55, 16 });
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                person.Surname = SurnameTB.Text;
                person.Salary = Convert.ToInt32(SalaryTB.Text);
                person.Position = PositionCB.Text;
                person.City = CityCB.Text;
                person.Street = StreetCB.Text;
                person.House = Convert.ToInt32(HouseCB.Text);
                WorkersListBox.Items.Add(person);
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = SurnameTB;
            SurnameTB.Clear();
            SalaryTB.Clear();
            PositionCB.SelectedIndex = -1;
            CityCB.SelectedIndex = -1;
            StreetCB.SelectedIndex = -1;
            HouseCB.SelectedIndex = -1;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);
                foreach (Person item in WorkersListBox.Items)
                    writer.WriteLine($"{item.Surname}|{item.Salary}|{item.Position}|{item.City}|{item.Street}|{item.House}");
                writer.Close();
            }
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(open.FileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { '|' });
                    Person newPerson = new Person();
                    newPerson.Surname = words[0];
                    newPerson.Salary = Convert.ToInt32(words[1]);
                    newPerson.Position =words[2];
                    newPerson.City = words[3];
                    newPerson.Street = words[4];
                    newPerson.House = Convert.ToInt32(words[5]);
                    WorkersListBox.Items.Add(newPerson);
                }
                reader.Close();
            }
        }

        // Second Task Tab
        private void StartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                Thread.Sleep(100);
            }
        }
    }
}
