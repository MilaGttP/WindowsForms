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
            this.LabMainTab = new System.Windows.Forms.TabPage();
            this.HWMainTab = new System.Windows.Forms.TabPage();
            this.LabTabControl = new System.Windows.Forms.TabControl();
            this.FirstLabTask = new System.Windows.Forms.TabPage();
            this.SecondLabTask = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FirstHWTask = new System.Windows.Forms.TabPage();
            this.SecondHWTask = new System.Windows.Forms.TabPage();
            this.ThirdHWTask = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.LabMainTab.SuspendLayout();
            this.HWMainTab.SuspendLayout();
            this.LabTabControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.LabMainTab);
            this.MainTabControl.Controls.Add(this.HWMainTab);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(856, 503);
            this.MainTabControl.TabIndex = 0;
            // 
            // LabMainTab
            // 
            this.LabMainTab.Controls.Add(this.LabTabControl);
            this.LabMainTab.Location = new System.Drawing.Point(4, 24);
            this.LabMainTab.Name = "LabMainTab";
            this.LabMainTab.Padding = new System.Windows.Forms.Padding(3);
            this.LabMainTab.Size = new System.Drawing.Size(848, 475);
            this.LabMainTab.TabIndex = 0;
            this.LabMainTab.Text = "Laboratory Work";
            this.LabMainTab.UseVisualStyleBackColor = true;
            // 
            // HWMainTab
            // 
            this.HWMainTab.Controls.Add(this.tabControl1);
            this.HWMainTab.Location = new System.Drawing.Point(4, 24);
            this.HWMainTab.Name = "HWMainTab";
            this.HWMainTab.Padding = new System.Windows.Forms.Padding(3);
            this.HWMainTab.Size = new System.Drawing.Size(848, 475);
            this.HWMainTab.TabIndex = 1;
            this.HWMainTab.Text = "Home Work";
            this.HWMainTab.UseVisualStyleBackColor = true;
            // 
            // LabTabControl
            // 
            this.LabTabControl.Controls.Add(this.FirstLabTask);
            this.LabTabControl.Controls.Add(this.SecondLabTask);
            this.LabTabControl.Location = new System.Drawing.Point(6, 6);
            this.LabTabControl.Name = "LabTabControl";
            this.LabTabControl.SelectedIndex = 0;
            this.LabTabControl.Size = new System.Drawing.Size(836, 463);
            this.LabTabControl.TabIndex = 0;
            // 
            // FirstLabTask
            // 
            this.FirstLabTask.Location = new System.Drawing.Point(4, 24);
            this.FirstLabTask.Name = "FirstLabTask";
            this.FirstLabTask.Padding = new System.Windows.Forms.Padding(3);
            this.FirstLabTask.Size = new System.Drawing.Size(828, 435);
            this.FirstLabTask.TabIndex = 0;
            this.FirstLabTask.Text = "Task 1";
            this.FirstLabTask.UseVisualStyleBackColor = true;
            // 
            // SecondLabTask
            // 
            this.SecondLabTask.Location = new System.Drawing.Point(4, 24);
            this.SecondLabTask.Name = "SecondLabTask";
            this.SecondLabTask.Padding = new System.Windows.Forms.Padding(3);
            this.SecondLabTask.Size = new System.Drawing.Size(828, 435);
            this.SecondLabTask.TabIndex = 1;
            this.SecondLabTask.Text = "Task 2";
            this.SecondLabTask.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FirstHWTask);
            this.tabControl1.Controls.Add(this.SecondHWTask);
            this.tabControl1.Controls.Add(this.ThirdHWTask);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // FirstHWTask
            // 
            this.FirstHWTask.Location = new System.Drawing.Point(4, 24);
            this.FirstHWTask.Name = "FirstHWTask";
            this.FirstHWTask.Padding = new System.Windows.Forms.Padding(3);
            this.FirstHWTask.Size = new System.Drawing.Size(828, 435);
            this.FirstHWTask.TabIndex = 0;
            this.FirstHWTask.Text = "Task 1";
            this.FirstHWTask.UseVisualStyleBackColor = true;
            // 
            // SecondHWTask
            // 
            this.SecondHWTask.Location = new System.Drawing.Point(4, 24);
            this.SecondHWTask.Name = "SecondHWTask";
            this.SecondHWTask.Padding = new System.Windows.Forms.Padding(3);
            this.SecondHWTask.Size = new System.Drawing.Size(828, 435);
            this.SecondHWTask.TabIndex = 1;
            this.SecondHWTask.Text = "Task 2";
            this.SecondHWTask.UseVisualStyleBackColor = true;
            // 
            // ThirdHWTask
            // 
            this.ThirdHWTask.Location = new System.Drawing.Point(4, 24);
            this.ThirdHWTask.Name = "ThirdHWTask";
            this.ThirdHWTask.Size = new System.Drawing.Size(828, 435);
            this.ThirdHWTask.TabIndex = 2;
            this.ThirdHWTask.Text = "Task 3";
            this.ThirdHWTask.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 527);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.LabMainTab.ResumeLayout(false);
            this.HWMainTab.ResumeLayout(false);
            this.LabTabControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage LabMainTab;
        private TabPage HWMainTab;
        private TabControl LabTabControl;
        private TabPage FirstLabTask;
        private TabPage SecondLabTask;
        private TabControl tabControl1;
        private TabPage FirstHWTask;
        private TabPage SecondHWTask;
        private TabPage ThirdHWTask;
    }
}