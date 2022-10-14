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
            this.LabTabControl = new System.Windows.Forms.TabControl();
            this.FirstLabTask = new System.Windows.Forms.TabPage();
            this.StrikeOutCB = new System.Windows.Forms.CheckBox();
            this.ResetLabTask1Button = new System.Windows.Forms.Button();
            this.OKLabTask1Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FontCB = new System.Windows.Forms.ComboBox();
            this.CheckingLabel = new System.Windows.Forms.Label();
            this.UnderlinedCB = new System.Windows.Forms.CheckBox();
            this.BoldCB = new System.Windows.Forms.CheckBox();
            this.SecondLabTask = new System.Windows.Forms.TabPage();
            this.ResetLab2TaskButton = new System.Windows.Forms.Button();
            this.OKLab2TaskButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.LabTask2Control = new System.Windows.Forms.TabControl();
            this.TextTab = new System.Windows.Forms.TabPage();
            this.SecondTextRB = new System.Windows.Forms.RadioButton();
            this.FirstTextRB = new System.Windows.Forms.RadioButton();
            this.ColorTab = new System.Windows.Forms.TabPage();
            this.BlueColorRB = new System.Windows.Forms.RadioButton();
            this.GreenColorRB = new System.Windows.Forms.RadioButton();
            this.RedColorRB = new System.Windows.Forms.RadioButton();
            this.SizeTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeFontCB = new System.Windows.Forms.ComboBox();
            this.HWMainTab = new System.Windows.Forms.TabPage();
            this.HWTabControl = new System.Windows.Forms.TabControl();
            this.FirstHWTask = new System.Windows.Forms.TabPage();
            this.SecondHWTask = new System.Windows.Forms.TabPage();
            this.ThirdHWTask = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.LabMainTab.SuspendLayout();
            this.LabTabControl.SuspendLayout();
            this.FirstLabTask.SuspendLayout();
            this.SecondLabTask.SuspendLayout();
            this.LabTask2Control.SuspendLayout();
            this.TextTab.SuspendLayout();
            this.ColorTab.SuspendLayout();
            this.SizeTab.SuspendLayout();
            this.HWMainTab.SuspendLayout();
            this.HWTabControl.SuspendLayout();
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
            // LabTabControl
            // 
            this.LabTabControl.Controls.Add(this.FirstLabTask);
            this.LabTabControl.Controls.Add(this.SecondLabTask);
            this.LabTabControl.Location = new System.Drawing.Point(6, 6);
            this.LabTabControl.Name = "LabTabControl";
            this.LabTabControl.SelectedIndex = 0;
            this.LabTabControl.Size = new System.Drawing.Size(836, 463);
            this.LabTabControl.TabIndex = 0;
            this.LabTabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexLabTabControl);
            // 
            // FirstLabTask
            // 
            this.FirstLabTask.Controls.Add(this.StrikeOutCB);
            this.FirstLabTask.Controls.Add(this.ResetLabTask1Button);
            this.FirstLabTask.Controls.Add(this.OKLabTask1Button);
            this.FirstLabTask.Controls.Add(this.label2);
            this.FirstLabTask.Controls.Add(this.FontCB);
            this.FirstLabTask.Controls.Add(this.CheckingLabel);
            this.FirstLabTask.Controls.Add(this.UnderlinedCB);
            this.FirstLabTask.Controls.Add(this.BoldCB);
            this.FirstLabTask.Location = new System.Drawing.Point(4, 24);
            this.FirstLabTask.Name = "FirstLabTask";
            this.FirstLabTask.Padding = new System.Windows.Forms.Padding(3);
            this.FirstLabTask.Size = new System.Drawing.Size(828, 435);
            this.FirstLabTask.TabIndex = 0;
            this.FirstLabTask.Text = "Task 1";
            this.FirstLabTask.UseVisualStyleBackColor = true;
            // 
            // StrikeOutCB
            // 
            this.StrikeOutCB.AutoSize = true;
            this.StrikeOutCB.Location = new System.Drawing.Point(228, 323);
            this.StrikeOutCB.Name = "StrikeOutCB";
            this.StrikeOutCB.Size = new System.Drawing.Size(76, 19);
            this.StrikeOutCB.TabIndex = 8;
            this.StrikeOutCB.Text = "Strike out";
            this.StrikeOutCB.UseVisualStyleBackColor = true;
            // 
            // ResetLabTask1Button
            // 
            this.ResetLabTask1Button.Location = new System.Drawing.Point(649, 320);
            this.ResetLabTask1Button.Name = "ResetLabTask1Button";
            this.ResetLabTask1Button.Size = new System.Drawing.Size(75, 23);
            this.ResetLabTask1Button.TabIndex = 7;
            this.ResetLabTask1Button.Text = "Reset";
            this.ResetLabTask1Button.UseVisualStyleBackColor = true;
            this.ResetLabTask1Button.Click += new System.EventHandler(this.ResetLabTask1Button_Click);
            // 
            // OKLabTask1Button
            // 
            this.OKLabTask1Button.Location = new System.Drawing.Point(548, 320);
            this.OKLabTask1Button.Name = "OKLabTask1Button";
            this.OKLabTask1Button.Size = new System.Drawing.Size(75, 23);
            this.OKLabTask1Button.TabIndex = 6;
            this.OKLabTask1Button.Text = "OK";
            this.OKLabTask1Button.UseVisualStyleBackColor = true;
            this.OKLabTask1Button.Click += new System.EventHandler(this.OKLabTask1Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter font size:";
            // 
            // FontCB
            // 
            this.FontCB.FormattingEnabled = true;
            this.FontCB.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.FontCB.Location = new System.Drawing.Point(310, 320);
            this.FontCB.Name = "FontCB";
            this.FontCB.Size = new System.Drawing.Size(147, 23);
            this.FontCB.TabIndex = 4;
            // 
            // CheckingLabel
            // 
            this.CheckingLabel.AutoSize = true;
            this.CheckingLabel.Location = new System.Drawing.Point(82, 165);
            this.CheckingLabel.Name = "CheckingLabel";
            this.CheckingLabel.Size = new System.Drawing.Size(215, 15);
            this.CheckingLabel.TabIndex = 3;
            this.CheckingLabel.Text = "This is a standart label for checking task";
            // 
            // UnderlinedCB
            // 
            this.UnderlinedCB.AutoSize = true;
            this.UnderlinedCB.Location = new System.Drawing.Point(138, 324);
            this.UnderlinedCB.Name = "UnderlinedCB";
            this.UnderlinedCB.Size = new System.Drawing.Size(84, 19);
            this.UnderlinedCB.TabIndex = 1;
            this.UnderlinedCB.Text = "Underlined";
            this.UnderlinedCB.UseVisualStyleBackColor = true;
            // 
            // BoldCB
            // 
            this.BoldCB.AutoSize = true;
            this.BoldCB.Location = new System.Drawing.Point(82, 324);
            this.BoldCB.Name = "BoldCB";
            this.BoldCB.Size = new System.Drawing.Size(50, 19);
            this.BoldCB.TabIndex = 0;
            this.BoldCB.Text = "Bold";
            this.BoldCB.UseVisualStyleBackColor = true;
            // 
            // SecondLabTask
            // 
            this.SecondLabTask.Controls.Add(this.ResetLab2TaskButton);
            this.SecondLabTask.Controls.Add(this.OKLab2TaskButton);
            this.SecondLabTask.Controls.Add(this.ResultLabel);
            this.SecondLabTask.Controls.Add(this.LabTask2Control);
            this.SecondLabTask.Location = new System.Drawing.Point(4, 24);
            this.SecondLabTask.Name = "SecondLabTask";
            this.SecondLabTask.Padding = new System.Windows.Forms.Padding(3);
            this.SecondLabTask.Size = new System.Drawing.Size(828, 435);
            this.SecondLabTask.TabIndex = 1;
            this.SecondLabTask.Text = "Task 2";
            this.SecondLabTask.UseVisualStyleBackColor = true;
            // 
            // ResetLab2TaskButton
            // 
            this.ResetLab2TaskButton.Location = new System.Drawing.Point(243, 387);
            this.ResetLab2TaskButton.Name = "ResetLab2TaskButton";
            this.ResetLab2TaskButton.Size = new System.Drawing.Size(75, 23);
            this.ResetLab2TaskButton.TabIndex = 3;
            this.ResetLab2TaskButton.Text = "Reset";
            this.ResetLab2TaskButton.UseVisualStyleBackColor = true;
            this.ResetLab2TaskButton.Click += new System.EventHandler(this.ResetLab2TaskButton_Click);
            // 
            // OKLab2TaskButton
            // 
            this.OKLab2TaskButton.Location = new System.Drawing.Point(134, 387);
            this.OKLab2TaskButton.Name = "OKLab2TaskButton";
            this.OKLab2TaskButton.Size = new System.Drawing.Size(75, 23);
            this.OKLab2TaskButton.TabIndex = 2;
            this.OKLab2TaskButton.Text = "OK";
            this.OKLab2TaskButton.UseVisualStyleBackColor = true;
            this.OKLab2TaskButton.Click += new System.EventHandler(this.OKLab2TaskButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(504, 203);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 15);
            this.ResultLabel.TabIndex = 1;
            // 
            // LabTask2Control
            // 
            this.LabTask2Control.Controls.Add(this.TextTab);
            this.LabTask2Control.Controls.Add(this.ColorTab);
            this.LabTask2Control.Controls.Add(this.SizeTab);
            this.LabTask2Control.Location = new System.Drawing.Point(29, 18);
            this.LabTask2Control.Name = "LabTask2Control";
            this.LabTask2Control.SelectedIndex = 0;
            this.LabTask2Control.Size = new System.Drawing.Size(407, 350);
            this.LabTask2Control.TabIndex = 0;
            // 
            // TextTab
            // 
            this.TextTab.Controls.Add(this.SecondTextRB);
            this.TextTab.Controls.Add(this.FirstTextRB);
            this.TextTab.Location = new System.Drawing.Point(4, 24);
            this.TextTab.Name = "TextTab";
            this.TextTab.Padding = new System.Windows.Forms.Padding(3);
            this.TextTab.Size = new System.Drawing.Size(399, 322);
            this.TextTab.TabIndex = 0;
            this.TextTab.Text = "Текст";
            this.TextTab.UseVisualStyleBackColor = true;
            // 
            // SecondTextRB
            // 
            this.SecondTextRB.AutoSize = true;
            this.SecondTextRB.Location = new System.Drawing.Point(60, 199);
            this.SecondTextRB.Name = "SecondTextRB";
            this.SecondTextRB.Size = new System.Drawing.Size(300, 34);
            this.SecondTextRB.TabIndex = 1;
            this.SecondTextRB.TabStop = true;
            this.SecondTextRB.Text = "Ніжна посмішка, єхидна, безсоромна, підленька, \r\nпоблажлива";
            this.SecondTextRB.UseVisualStyleBackColor = true;
            // 
            // FirstTextRB
            // 
            this.FirstTextRB.AutoSize = true;
            this.FirstTextRB.Location = new System.Drawing.Point(60, 106);
            this.FirstTextRB.Name = "FirstTextRB";
            this.FirstTextRB.Size = new System.Drawing.Size(286, 19);
            this.FirstTextRB.TabIndex = 0;
            this.FirstTextRB.TabStop = true;
            this.FirstTextRB.Text = "Захоплена, співчутлива, скромно - збентежена";
            this.FirstTextRB.UseVisualStyleBackColor = true;
            // 
            // ColorTab
            // 
            this.ColorTab.Controls.Add(this.BlueColorRB);
            this.ColorTab.Controls.Add(this.GreenColorRB);
            this.ColorTab.Controls.Add(this.RedColorRB);
            this.ColorTab.Location = new System.Drawing.Point(4, 24);
            this.ColorTab.Name = "ColorTab";
            this.ColorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ColorTab.Size = new System.Drawing.Size(399, 322);
            this.ColorTab.TabIndex = 1;
            this.ColorTab.Text = "Колір";
            this.ColorTab.UseVisualStyleBackColor = true;
            // 
            // BlueColorRB
            // 
            this.BlueColorRB.AutoSize = true;
            this.BlueColorRB.Location = new System.Drawing.Point(71, 218);
            this.BlueColorRB.Name = "BlueColorRB";
            this.BlueColorRB.Size = new System.Drawing.Size(48, 19);
            this.BlueColorRB.TabIndex = 2;
            this.BlueColorRB.Text = "Blue";
            this.BlueColorRB.UseVisualStyleBackColor = true;
            // 
            // GreenColorRB
            // 
            this.GreenColorRB.AutoSize = true;
            this.GreenColorRB.Location = new System.Drawing.Point(71, 147);
            this.GreenColorRB.Name = "GreenColorRB";
            this.GreenColorRB.Size = new System.Drawing.Size(56, 19);
            this.GreenColorRB.TabIndex = 1;
            this.GreenColorRB.Text = "Green";
            this.GreenColorRB.UseVisualStyleBackColor = true;
            // 
            // RedColorRB
            // 
            this.RedColorRB.AutoSize = true;
            this.RedColorRB.Location = new System.Drawing.Point(71, 76);
            this.RedColorRB.Name = "RedColorRB";
            this.RedColorRB.Size = new System.Drawing.Size(45, 19);
            this.RedColorRB.TabIndex = 0;
            this.RedColorRB.Text = "Red";
            this.RedColorRB.UseVisualStyleBackColor = true;
            // 
            // SizeTab
            // 
            this.SizeTab.Controls.Add(this.label1);
            this.SizeTab.Controls.Add(this.SizeFontCB);
            this.SizeTab.Location = new System.Drawing.Point(4, 24);
            this.SizeTab.Name = "SizeTab";
            this.SizeTab.Size = new System.Drawing.Size(399, 322);
            this.SizeTab.TabIndex = 2;
            this.SizeTab.Text = "Розмір";
            this.SizeTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter:";
            // 
            // SizeFontCB
            // 
            this.SizeFontCB.FormattingEnabled = true;
            this.SizeFontCB.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42"});
            this.SizeFontCB.Location = new System.Drawing.Point(57, 93);
            this.SizeFontCB.Name = "SizeFontCB";
            this.SizeFontCB.Size = new System.Drawing.Size(162, 23);
            this.SizeFontCB.TabIndex = 0;
            // 
            // HWMainTab
            // 
            this.HWMainTab.Controls.Add(this.HWTabControl);
            this.HWMainTab.Location = new System.Drawing.Point(4, 24);
            this.HWMainTab.Name = "HWMainTab";
            this.HWMainTab.Padding = new System.Windows.Forms.Padding(3);
            this.HWMainTab.Size = new System.Drawing.Size(848, 475);
            this.HWMainTab.TabIndex = 1;
            this.HWMainTab.Text = "Home Work";
            this.HWMainTab.UseVisualStyleBackColor = true;
            // 
            // HWTabControl
            // 
            this.HWTabControl.Controls.Add(this.FirstHWTask);
            this.HWTabControl.Controls.Add(this.SecondHWTask);
            this.HWTabControl.Controls.Add(this.ThirdHWTask);
            this.HWTabControl.Location = new System.Drawing.Point(6, 6);
            this.HWTabControl.Name = "HWTabControl";
            this.HWTabControl.SelectedIndex = 0;
            this.HWTabControl.Size = new System.Drawing.Size(836, 463);
            this.HWTabControl.TabIndex = 0;
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
            this.LabTabControl.ResumeLayout(false);
            this.FirstLabTask.ResumeLayout(false);
            this.FirstLabTask.PerformLayout();
            this.SecondLabTask.ResumeLayout(false);
            this.SecondLabTask.PerformLayout();
            this.LabTask2Control.ResumeLayout(false);
            this.TextTab.ResumeLayout(false);
            this.TextTab.PerformLayout();
            this.ColorTab.ResumeLayout(false);
            this.ColorTab.PerformLayout();
            this.SizeTab.ResumeLayout(false);
            this.SizeTab.PerformLayout();
            this.HWMainTab.ResumeLayout(false);
            this.HWTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage LabMainTab;
        private TabPage HWMainTab;
        private TabControl LabTabControl;
        private TabPage FirstLabTask;
        private TabPage SecondLabTask;
        private TabControl HWTabControl;
        private TabPage FirstHWTask;
        private TabPage SecondHWTask;
        private TabPage ThirdHWTask;
        private Label label2;
        private ComboBox FontCB;
        private Label CheckingLabel;
        private CheckBox UnderlinedCB;
        private CheckBox BoldCB;
        private Button ResetLabTask1Button;
        private Button OKLabTask1Button;
        private CheckBox StrikeOutCB;
        private TabControl LabTask2Control;
        private TabPage TextTab;
        private TabPage ColorTab;
        private TabPage SizeTab;
        private Label ResultLabel;
        private RadioButton SecondTextRB;
        private RadioButton FirstTextRB;
        private RadioButton BlueColorRB;
        private RadioButton GreenColorRB;
        private RadioButton RedColorRB;
        private Label label1;
        private ComboBox SizeFontCB;
        private Button ResetLab2TaskButton;
        private Button OKLab2TaskButton;
    }
}