
namespace WindowsForms
{
    public partial class MainForm : Form
    {
        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text != "") TopMenu.Items.Add(TopLevelMenu.Text);
            else
            {
                MessageBox.Show("Add a name of menu item", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void AddSubMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem temp;
            if (TopMenu.Items.Count < 1)
            {
                MessageBox.Show("Add a menu item", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TopLevelMenu.Text != "")
            {
                for (int i = 0; i < TopMenu.Items.Count; i++)
                {
                    if (TopMenu.Items[i].Text == TopLevelMenu.Text)
                    {
                        if (SubItem.Text != "")
                        {
                            temp = (ToolStripMenuItem) TopMenu.Items[i];
                            temp.DropDownItems.Add(SubItem.Text);
                        }
                        else
                        {
                            MessageBox.Show("Add a name of submenu item", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Add a name of menu item", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}