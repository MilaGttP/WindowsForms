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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.FirstTaskTab = new System.Windows.Forms.TabPage();
            this.SecondTaskTab = new System.Windows.Forms.TabPage();
            this.ThirdTaskTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.FirstTaskTab);
            this.tabControl.Controls.Add(this.SecondTaskTab);
            this.tabControl.Controls.Add(this.ThirdTaskTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(835, 526);
            this.tabControl.TabIndex = 0;
            // 
            // FirstTaskTab
            // 
            this.FirstTaskTab.Location = new System.Drawing.Point(4, 24);
            this.FirstTaskTab.Name = "FirstTaskTab";
            this.FirstTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTaskTab.Size = new System.Drawing.Size(827, 498);
            this.FirstTaskTab.TabIndex = 0;
            this.FirstTaskTab.Text = "First Task";
            this.FirstTaskTab.UseVisualStyleBackColor = true;
            // 
            // SecondTaskTab
            // 
            this.SecondTaskTab.Location = new System.Drawing.Point(4, 24);
            this.SecondTaskTab.Name = "SecondTaskTab";
            this.SecondTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTaskTab.Size = new System.Drawing.Size(827, 498);
            this.SecondTaskTab.TabIndex = 1;
            this.SecondTaskTab.Text = "Second Task";
            this.SecondTaskTab.UseVisualStyleBackColor = true;
            // 
            // ThirdTaskTab
            // 
            this.ThirdTaskTab.Location = new System.Drawing.Point(4, 24);
            this.ThirdTaskTab.Name = "ThirdTaskTab";
            this.ThirdTaskTab.Size = new System.Drawing.Size(827, 498);
            this.ThirdTaskTab.TabIndex = 2;
            this.ThirdTaskTab.Text = "Third Task";
            this.ThirdTaskTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage FirstTaskTab;
        private TabPage SecondTaskTab;
        private TabPage ThirdTaskTab;
    }
}