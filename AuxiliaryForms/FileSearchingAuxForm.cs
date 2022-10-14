
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FileSearchingAuxForm : Form
    {
        public FileSearchingAuxForm() => InitializeComponent();
        private void OKButton_Click(object sender, EventArgs e)
        {
            try {
                if (ExtensionTB.Text == "")
                {
                    MessageBox.Show("Enter extension!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    string[] list = Directory.GetFiles(folder.SelectedPath, ExtensionTB.Text, SearchOption.AllDirectories);
                    FileListBox.Items.Clear();
                    if (list.Length != 0) foreach (var item in list) FileListBox.Items.Add(item);
                    else MessageBox.Show($"Files hadn`t been finded!", "Ou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
