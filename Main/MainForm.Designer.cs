namespace WindowsForms
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Task1 = new System.Windows.Forms.TabPage();
            this.treeViewExplorer = new System.Windows.Forms.TreeView();
            this.Task2 = new System.Windows.Forms.TabPage();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.RichTB = new System.Windows.Forms.RichTextBox();
            this.treeViewEditor = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.Task1.SuspendLayout();
            this.Task2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Task1);
            this.MainTabControl.Controls.Add(this.Task2);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(799, 493);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // Task1
            // 
            this.Task1.Controls.Add(this.treeViewExplorer);
            this.Task1.Location = new System.Drawing.Point(4, 24);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(791, 465);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task 1";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // treeViewExplorer
            // 
            this.treeViewExplorer.Location = new System.Drawing.Point(18, 19);
            this.treeViewExplorer.Name = "treeViewExplorer";
            this.treeViewExplorer.Size = new System.Drawing.Size(751, 427);
            this.treeViewExplorer.TabIndex = 0;
            // 
            // Task2
            // 
            this.Task2.Controls.Add(this.toolStrip);
            this.Task2.Controls.Add(this.RichTB);
            this.Task2.Controls.Add(this.treeViewEditor);
            this.Task2.Controls.Add(this.menuStrip);
            this.Task2.Location = new System.Drawing.Point(4, 24);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(791, 465);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Location = new System.Drawing.Point(3, 437);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(785, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // RichTB
            // 
            this.RichTB.Location = new System.Drawing.Point(178, 51);
            this.RichTB.Name = "RichTB";
            this.RichTB.Size = new System.Drawing.Size(578, 364);
            this.RichTB.TabIndex = 2;
            this.RichTB.Text = "";
            // 
            // treeViewEditor
            // 
            this.treeViewEditor.Location = new System.Drawing.Point(6, 39);
            this.treeViewEditor.Name = "treeViewEditor";
            this.treeViewEditor.Size = new System.Drawing.Size(156, 391);
            this.treeViewEditor.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.correctionToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(785, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // correctionToolStripMenuItem
            // 
            this.correctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.forwardToolStripMenuItem});
            this.correctionToolStripMenuItem.Name = "correctionToolStripMenuItem";
            this.correctionToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.correctionToolStripMenuItem.Text = "Correction";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem,
            this.leftSideToolStripMenuItem,
            this.rightSideToolStripMenuItem,
            this.tabulationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontColorToolStripMenuItem.Text = "Font color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // leftSideToolStripMenuItem
            // 
            this.leftSideToolStripMenuItem.Name = "leftSideToolStripMenuItem";
            this.leftSideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leftSideToolStripMenuItem.Text = "Left side";
            this.leftSideToolStripMenuItem.Click += new System.EventHandler(this.leftSideToolStripMenuItem_Click);
            // 
            // rightSideToolStripMenuItem
            // 
            this.rightSideToolStripMenuItem.Name = "rightSideToolStripMenuItem";
            this.rightSideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightSideToolStripMenuItem.Text = "Right side";
            this.rightSideToolStripMenuItem.Click += new System.EventHandler(this.rightSideToolStripMenuItem_Click);
            // 
            // tabulationToolStripMenuItem
            // 
            this.tabulationToolStripMenuItem.Name = "tabulationToolStripMenuItem";
            this.tabulationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabulationToolStripMenuItem.Text = "Tabulation";
            this.tabulationToolStripMenuItem.Click += new System.EventHandler(this.tabulationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 517);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.Task2.ResumeLayout(false);
            this.Task2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage Task1;
        private TabPage Task2;
        private TreeView treeViewExplorer;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem correctionToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private TreeView treeViewEditor;
        private ToolStrip toolStrip;
        private RichTextBox RichTB;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem forwardToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem fontColorToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem centerToolStripMenuItem;
        private ToolStripMenuItem leftSideToolStripMenuItem;
        private ToolStripMenuItem rightSideToolStripMenuItem;
        private ToolStripMenuItem tabulationToolStripMenuItem;
    }
}