namespace WindowsForms
{
    partial class PersonListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolsMenu = new System.Windows.Forms.MenuStrip();
            this.addTool = new System.Windows.Forms.ToolStripMenuItem();
            this.editTool = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTool = new System.Windows.Forms.ToolStripMenuItem();
            this.personList = new System.Windows.Forms.ListBox();
            this.ToolsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.ToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTool,
            this.editTool,
            this.deleteTool,
            this.clearAllTool,
            this.saveTool,
            this.loadTool});
            this.ToolsMenu.Location = new System.Drawing.Point(3, 64);
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(613, 24);
            this.ToolsMenu.TabIndex = 1;
            this.ToolsMenu.Text = "Tools";
            // 
            // addTool
            // 
            this.addTool.Name = "addTool";
            this.addTool.Size = new System.Drawing.Size(41, 20);
            this.addTool.Text = "Add";
            this.addTool.Click += new System.EventHandler(this.addTool_Click);
            // 
            // editTool
            // 
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(39, 20);
            this.editTool.Text = "Edit";
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // deleteTool
            // 
            this.deleteTool.Name = "deleteTool";
            this.deleteTool.Size = new System.Drawing.Size(52, 20);
            this.deleteTool.Text = "Delete";
            this.deleteTool.Click += new System.EventHandler(this.deleteTool_Click);
            // 
            // clearAllTool
            // 
            this.clearAllTool.Name = "clearAllTool";
            this.clearAllTool.Size = new System.Drawing.Size(61, 20);
            this.clearAllTool.Text = "Clear all";
            this.clearAllTool.Click += new System.EventHandler(this.clearAllTool_Click);
            // 
            // saveTool
            // 
            this.saveTool.Name = "saveTool";
            this.saveTool.Size = new System.Drawing.Size(43, 20);
            this.saveTool.Text = "Save";
            this.saveTool.Click += new System.EventHandler(this.saveTool_Click);
            // 
            // loadTool
            // 
            this.loadTool.Name = "loadTool";
            this.loadTool.Size = new System.Drawing.Size(45, 20);
            this.loadTool.Text = "Load";
            this.loadTool.Click += new System.EventHandler(this.loadTool_Click);
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.ItemHeight = 15;
            this.personList.Location = new System.Drawing.Point(23, 105);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(570, 304);
            this.personList.TabIndex = 2;
            // 
            // PersonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 431);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.ToolsMenu);
            this.MainMenuStrip = this.ToolsMenu;
            this.Name = "PersonListForm";
            this.Text = "PersonListForm";
            this.ToolsMenu.ResumeLayout(false);
            this.ToolsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip ToolsMenu;
        private ToolStripMenuItem editTool;
        private ToolStripMenuItem deleteTool;
        private ToolStripMenuItem clearAllTool;
        private ToolStripMenuItem saveTool;
        private ToolStripMenuItem loadTool;
        private ListBox personList;
        private ToolStripMenuItem addTool;
    }
}