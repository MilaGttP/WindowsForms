using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsForms
{
    public partial class HWTask1Form : MaterialForm
    {
        public HWTask1Form()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            this.ActiveControl = SurnameTB;
        }
        private bool Check(MaterialTextBox textBox)
        {
            if (textBox.Text == "") return false;
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Check(SurnameTB) && Check(NameTB) && Check(PatronymicTB) && Check(GenderTB) && Check(FamilyStatTB))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFile.FileName);
                    writer.WriteLine($"{SurnameTB.Text}, {NameTB.Text}, {PatronymicTB.Text}, " +
                        $"{GenderTB.Text}, {FamilyStatTB.Text}, {AuxInfTB.Text}, {dateTimePicker.Value}");
                    writer.Close();

                }
            }
            else MessageBox.Show("One or more of textboxes are empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = SurnameTB;
            SurnameTB.Clear();
            NameTB.Clear();
            PatronymicTB.Clear();
            GenderTB.Clear();
            FamilyStatTB.Clear();
            AuxInfTB.Clear();
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
