
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        private string pathForEditor;
        private void OpenFileTool_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileTB.ReadOnly = false;
                contextMenuForTextEditor.Enabled = true;
                SaveFileTool.Enabled = true;
                CutOutContextTool.Enabled = true;
                CopyContextTool.Enabled = true;
                CancelContextTool.Enabled = true;
                SelectAllContextTool.Enabled = true;
                pathForEditor = dialog.FileName;
                Text = $"Текстовый редактор - {pathForEditor}";
                StreamReader reading = new StreamReader(dialog.FileName, Encoding.Default);
                FileTB.Text = reading.ReadToEnd();
                reading.Close();
            }
        }
        private void SaveFileTool_Click(object sender, EventArgs e)
        {
            if (pathForEditor != "")
            {
                StreamWriter writing = new StreamWriter(pathForEditor, false, Encoding.Default);
                writing.Write(FileTB.Text);
                writing.Close();
            }
            else MessageBox.Show("File hadn`t selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void NewFileTool_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileTB.ReadOnly = false;
                contextMenuForTextEditor.Enabled = true;
                SaveFileTool.Enabled = true;
                CutOutContextTool.Enabled = true;
                CopyContextTool.Enabled = true;
                CancelContextTool.Enabled = true;
                SelectAllContextTool.Enabled = true;
                pathForEditor = dialog.FileName;
                Text = $"Text editor - {pathForEditor}";
                StreamWriter writing = new StreamWriter(pathForEditor, false, Encoding.Default);
                writing.Write(FileTB.Text);
                writing.Close();
            }
        }
        private void CopyContextTool_Click(object sender, EventArgs e) => FileTB.Copy();
        private void CutOutContextTool_Click(object sender, EventArgs e) => FileTB.Cut();
        private void PasteContextTool_Click(object sender, EventArgs e) => FileTB.Paste();
        private void CancelContextTool_Click(object sender, EventArgs e)
        {
            if (FileTB.CanUndo == true) { FileTB.Undo(); FileTB.ClearUndo(); }
        }
        private void SelectAllContextTool_Click(object sender, EventArgs e) => FileTB.SelectAll();
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
