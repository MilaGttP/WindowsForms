
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        List <string> pathForExp { get; set; }
        public void SearchDrives()
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            DrivesLabelForExp.Text = $"Elements: {drive.Length}";
            DirsLabelForExp.Text = $"Elements: 0";
            foreach (DriveInfo item in drive) DrivesLB.Items.Add(item);            
        }
        private void DrivesLB_Click(object sender, EventArgs e)
        {
            if (DrivesLB.SelectedItem == "...") return;
            if (DrivesLB.SelectedIndex != -1)
            {
                PathTB.Text = DrivesLB.SelectedItem.ToString();
                DirsLB.ClearSelected();
            }
        }
        private void DirsLB_Click(object sender, EventArgs e)
        {
            if (DirsLB.SelectedIndex != -1)
            {
                PathTB.Text = DirsLB.SelectedItem.ToString();
                DrivesLB.ClearSelected();
            }
        }
        private void OpenToolForExp_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirsLB.SelectedIndex != -1)
                {
                    pathForExp.Add(DirsLB.SelectedItem.ToString());
                    if (File.Exists(pathForExp[pathForExp.Count - 1])) Process.Start(pathForExp[pathForExp.Count - 1]);
                    else SearchFile();
                }
                if (DrivesLB.SelectedIndex != -1)
                {
                    pathForExp.Add(DrivesLB.SelectedItem.ToString());
                    if (File.Exists(pathForExp[pathForExp.Count - 1])) Process.Start(pathForExp[pathForExp.Count - 1]);
                    else SearchFile();
                }
            }
            catch (Exception)
            {
                pathForExp.Clear();
                PathTB.Visible = false;
                DrivesLB.Items.Clear();
                DirsLB.Items.Clear();
                SearchDrives();
                MessageBox.Show("Impossible to open a directory", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void BackToolExp_Click(object sender, EventArgs e)
        {
            if (pathForExp.Count == 0) return;
            if (pathForExp.Count == 1)
            {
                pathForExp.RemoveAt(pathForExp.Count - 1);
                DrivesLB.Items.Clear();
                DirsLB.Items.Clear();
                SearchDrives();
                PathTB.Visible = false;
                PathTB.Text = "";
            }
            else
            {
                pathForExp.RemoveAt(pathForExp.Count - 1);
                SearchFile();
            }
        }
        private void DrivesLB_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DrivesLB.SelectedItem == "...")
                {
                    pathForExp.RemoveAt(pathForExp.Count - 1);
                    SearchFile();
                }
                if (DrivesLB.SelectedIndex != -1)
                {
                    pathForExp.Add(DrivesLB.SelectedItem.ToString());
                    SearchFile();
                    PathTB.Visible = true;
                }
                if (DirsLB.SelectedIndex != -1)
                {
                    pathForExp.Add(DirsLB.SelectedItem.ToString());
                    if (File.Exists(pathForExp[pathForExp.Count - 1])) Process.Start(pathForExp[pathForExp.Count - 1]);
                    else SearchFile();
                }
            }
            catch (Exception)
            {
                pathForExp.Clear();
                PathTB.Visible = false;
                DrivesLB.Items.Clear();
                DirsLB.Items.Clear();
                SearchDrives();
                MessageBox.Show("Impossible to open a directory", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void SearchFile()
        {
            DrivesLB.Items.Clear();
            DirsLB.Items.Clear();
            string[] dir = Directory.GetDirectories(pathForExp[pathForExp.Count - 1]);
            string[] file = Directory.GetFiles(pathForExp[pathForExp.Count - 1]);
            if (dir.Length < 1) DrivesLB.Items.Add($"...");
            foreach (var item in dir)
            {
                DrivesLB.Items.Add(item);
                DirsLB.Items.Add(item);
            }
            foreach (var item in file) DirsLB.Items.Add(item);
            if (DrivesLB.Items[0] == "...") DrivesLabelForExp.Text = $"Elements: 0";
            else DrivesLabelForExp.Text = $"Elements: {DrivesLB.Items.Count}";
            DirsLabelForExp.Text = $"Elements: {DirsLB.Items.Count}";
            PathTB.Text = pathForExp[pathForExp.Count - 1];
        }
    }
}
