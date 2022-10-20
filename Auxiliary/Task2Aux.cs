using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        OpenFileDialog openFile = null;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.FileName != "")
            {
                if (openFile.FileName.EndsWith("rtf"))
                {
                    RichTB.SaveFile(openFile.FileName, RichTextBoxStreamType.RichText);
                }
                else RichTB.SaveFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) => Refresh();
        private void backToolStripMenuItem_Click(object sender, EventArgs e) => RichTB.Undo();
        private void forwardToolStripMenuItem_Click(object sender, EventArgs e) => RichTB.Redo();
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = RichTB.SelectionFont;
            dialog.Color = RichTB.SelectionColor;
            dialog.ShowColor = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RichTB.SelectionFont = dialog.Font;
                RichTB.SelectionColor = dialog.Color;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = RichTB.SelectionColor;
            if (dialog.ShowDialog() == DialogResult.OK) RichTB.SelectionColor = dialog.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = RichTB.SelectionBackColor;
            if (dialog.ShowDialog() == DialogResult.OK) RichTB.SelectionBackColor = dialog.Color;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e) => RichTB.SelectionAlignment = HorizontalAlignment.Center;
        private void leftSideToolStripMenuItem_Click(object sender, EventArgs e) => RichTB.SelectionAlignment = HorizontalAlignment.Left;
        private void rightSideToolStripMenuItem_Click(object sender, EventArgs e) => RichTB.SelectionAlignment = HorizontalAlignment.Right;
        private void tabulationToolStripMenuItem_Click(object sender, EventArgs e) => RichTB.SelectionIndent = 20;
        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            RichTB.ReadOnly = false;
            TreeNode s = (TreeNode)e.Item;
            openFile = new OpenFileDialog();
            DoDragDrop(s.FullPath, DragDropEffects.Copy | DragDropEffects.Move);
            try
            {
                if (openFile.FileName.EndsWith("rtf"))
                {
                    RichTB.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                    {
                        RichTB.Text = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Refresh();
            }
        }

        private void TreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    string[] dir = Directory.GetDirectories(e.Node.FullPath);
                    for (int i = 0; i < dir.Length; i++)
                    {
                        TreeNode dirNode = new TreeNode(new DirectoryInfo(dir[i]).Name);
                        FillTreeNode(dirNode, dir[i]);
                        e.Node.Nodes.Add(dirNode);
                    }
                    string[] file = Directory.GetFiles(e.Node.FullPath);
                    for (int i = 0; i < file.Length; i++)
                    {
                        TreeNode fileNode = new TreeNode(new DirectoryInfo(file[i]).Name);
                        e.Node.Nodes.Add(fileNode);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Refresh();
            }
        }
        private void DirectoryTreeNode()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode treeNode = new TreeNode(drive.Name);
                    FillTreeNode(treeNode, drive.Name);
                    treeViewEditor.Nodes.Add(treeNode);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Refresh();
            }
        }
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode(dir.Remove(0, dir.LastIndexOf("\\") + 1));
                    driveNode.Nodes.Add(dirNode);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    TreeNode fileNode = new TreeNode(new DirectoryInfo(file).Name);
                    driveNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Refresh();
            }
        }
    }
}
