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
            this.Task2 = new System.Windows.Forms.TabPage();
            this.Task3 = new System.Windows.Forms.TabPage();
            this.Task4 = new System.Windows.Forms.TabPage();
            this.treeViewExplorer = new System.Windows.Forms.TreeView();
            this.MainTabControl.SuspendLayout();
            this.Task1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Task1);
            this.MainTabControl.Controls.Add(this.Task2);
            this.MainTabControl.Controls.Add(this.Task3);
            this.MainTabControl.Controls.Add(this.Task4);
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
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(4, 24);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(791, 465);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(4, 24);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(791, 465);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Task 3";
            this.Task3.UseVisualStyleBackColor = true;
            // 
            // Task4
            // 
            this.Task4.Location = new System.Drawing.Point(4, 24);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(791, 465);
            this.Task4.TabIndex = 3;
            this.Task4.Text = "Task 4";
            this.Task4.UseVisualStyleBackColor = true;
            // 
            // treeViewExplorer
            // 
            this.treeViewExplorer.Location = new System.Drawing.Point(18, 19);
            this.treeViewExplorer.Name = "treeViewExplorer";
            this.treeViewExplorer.Size = new System.Drawing.Size(751, 427);
            this.treeViewExplorer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 517);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage Task1;
        private TabPage Task2;
        private TabPage Task3;
        private TabPage Task4;
        private TreeView treeViewExplorer;
    }
}