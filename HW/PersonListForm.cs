using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsForms
{
    public partial class PersonListForm : MaterialForm
    {
        private Person person = null;
        private int index;
        public PersonListForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.Brown200, Primary.Brown400,
                Primary.Brown400, Accent.Amber100,
                TextShade.WHITE
            );
            person = new Person();
        }

        private void addTool_Click(object sender, EventArgs e)
        {
            person = new Person();
            QuestionaryForm addForm = new QuestionaryForm(person, true);
            if (addForm.ShowDialog() == DialogResult.OK)
                personList.Items.Add(person);
        }
        private void editTool_Click(object sender, EventArgs e)
        {
            person = (Person)personList.SelectedItem;
            QuestionaryForm addForm = new QuestionaryForm(person, false);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                index = personList.SelectedIndex;
                personList.Items.RemoveAt(index);
                personList.Items.Insert(index, person);
            }
        }
        private void deleteTool_Click(object sender, EventArgs e)
        {
            if (personList.SelectedIndex == -1)
            {
                MessageBox.Show("Goods hasn`t choosen!");
                return;
            }
            personList.Items.RemoveAt(personList.SelectedIndex);
        }
        private void clearAllTool_Click(object sender, EventArgs e) => personList.Items.Clear();
        private void saveTool_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);
                foreach (Person item in personList.Items)
                    writer.WriteLine($"{item.Name}|{item.Surname}|{item.Email}|{item.Phone}");
                writer.Close();
            }
        }
        private void loadTool_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFile.FileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { '|' });
                    Person newPerson = new Person();
                    newPerson.Name = words[0];
                    newPerson.Surname = words[1];
                    newPerson.Email = words[2];
                    newPerson.Phone = words[3];
                    personList.Items.Add(newPerson);
                }
                reader.Close();
            }
        }
    }
}
