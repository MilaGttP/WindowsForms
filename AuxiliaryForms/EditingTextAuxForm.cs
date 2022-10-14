using MaterialSkin.Controls;
using System;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WindowsForms
{
    public partial class EditingTextAuxForm : Form
    {
        MainForm mainForm;
        public EditingTextAuxForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            EditingTB.Text = mainForm.TextBoxReading;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            mainForm.TextBoxReading = EditingTB.Text;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.Default);
                writer.Write(EditingTB.Text);
                writer.Close();
            }
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) => Close();
    }
}
