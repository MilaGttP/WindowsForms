using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class QuestionaryForm : MaterialForm
    {
        Person person = null;
        bool trigger;
        public QuestionaryForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.Brown200, Primary.Brown400,
                Primary.Brown400, Accent.DeepOrange100,
                TextShade.WHITE
            );
            this.ActiveControl = NameTB;
        }
        public QuestionaryForm(Person person, bool trigger)
        {
            InitializeComponent();
            this.person = person;
            this.components = components;
            this.trigger = trigger; 
        }
        private bool CheckName()
        {
            if (NameTB.Text == "") return false;
            else return CheckSurname();
        }
        private bool CheckSurname()
        {
            if (SurnameTB.Text == "") return false;
            return CheckEmail();
        }
        private bool CheckEmail()
        {
            // regex ?
            if (EmailTB.Text == "") return false;
            return CheckPhone();
        }
        private bool CheckPhone()
        {
            // regex ?
            if (PhoneTB.Text == "") return false;
            return true;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckName())
            {
                if (person == null) person = new Person();
                person.Name = NameTB.Text;
                person.Surname = SurnameTB.Text;
                person.Email = EmailTB.Text;
                person.Phone = PhoneTB.Text;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            NameTB.Clear();
            SurnameTB.Clear();
            EmailTB.Clear();
            PhoneTB.Clear();
            this.ActiveControl = NameTB;
        }
        private void BackButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
    }
}
