
namespace WindowsForms
{
    public partial class MainForm : Form
    {
        private void OpenFileTool_Click(object sender, EventArgs e)
        {

        }
        private void SaveFileTool_Click(object sender, EventArgs e)
        {

        }
        private void NewFileTool_Click(object sender, EventArgs e)
        {

        }

        private void CopyFileTool_Click(object sender, EventArgs e)
        {

        }
        private void CutOutFileTool_Click(object sender, EventArgs e)
        {

        }
        private void PasteFileTool_Click(object sender, EventArgs e)
        {

        }
        private void CancelFileTool_Click(object sender, EventArgs e)
        {

        }
        private void FontColorFileTool_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) FileTB.ForeColor = dialog.Color;
        }
        private void BackColorFileTool_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) FileTB.BackColor = dialog.Color;
        }
        private void FontFileTool_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK) FileTB.Font = dialog.Font;
        }
    }
}