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

        #region Windows Form Des#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.FileTB = new System.Windows.Forms.RichTextBox();
            this.contextMenuForTextEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CutOutContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForTextEditor = new System.Windows.Forms.MenuStrip();
            this.FileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColorFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BackColorFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.FontFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondHWTask = new System.Windows.Forms.TabPage();
            this.toolStripForExplorer = new System.Windows.Forms.ToolStrip();
            this.DrivesLabelForExp = new System.Windows.Forms.ToolStripLabel();
            this.DirsLabelForExp = new System.Windows.Forms.ToolStripLabel();
            this.DirsLB = new System.Windows.Forms.ListBox();
            this.DrivesLB = new System.Windows.Forms.ListBox();
            this.menuForExplorer = new System.Windows.Forms.MenuStrip();
            this.BackToolExp = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolExp = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolForExp = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripForExp = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.PathTB = new System.Windows.Forms.ToolStripTextBox();
            this.ThirdHWTask = new System.Windows.Forms.TabPage();
            this.contextMenuForExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenContextForExp = new System.Windows.Forms.ToolStripMenuItem();
            this.BackContextForExp = new System.Windows.Forms.ToolStripMenuItem();
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
            this.FirstHWTask.SuspendLayout();
            this.contextMenuForTextEditor.SuspendLayout();
            this.menuForTextEditor.SuspendLayout();
            this.SecondHWTask.SuspendLayout();
            this.toolStripForExplorer.SuspendLayout();
            this.menuForExplorer.SuspendLayout();
            this.contextMenuForExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.LabMainTab);
            this.MainTabControl.Controls.Add(this.HWMainTab);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(884, 532);
            this.MainTabControl.TabIndex = 0;
            // 
            // LabMainTab
            // 
            this.LabMainTab.Controls.Add(this.LabTabControl);
            this.LabMainTab.Location = new System.Drawing.Point(4, 24);
            this.LabMainTab.Name = "LabMainTab";
            this.LabMainTab.Padding = new System.Windows.Forms.Padding(3);
            this.LabMainTab.Size = new System.Drawing.Size(876, 504);
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
            this.HWMainTab.Size = new System.Drawing.Size(876, 504);
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
            this.HWTabControl.Size = new System.Drawing.Size(864, 492);
            this.HWTabControl.TabIndex = 0;
            this.HWTabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexHWTabControl);
            // 
            // FirstHWTask
            // 
            this.FirstHWTask.Controls.Add(this.FileTB);
            this.FirstHWTask.Controls.Add(this.menuForTextEditor);
            this.FirstHWTask.Location = new System.Drawing.Point(4, 24);
            this.FirstHWTask.Name = "FirstHWTask";
            this.FirstHWTask.Padding = new System.Windows.Forms.Padding(3);
            this.FirstHWTask.Size = new System.Drawing.Size(856, 464);
            this.FirstHWTask.TabIndex = 0;
            this.FirstHWTask.Text = "Task 1";
            this.FirstHWTask.UseVisualStyleBackColor = true;
            // 
            // FileTB
            // 
            this.FileTB.ContextMenuStrip = this.contextMenuForTextEditor;
            this.FileTB.Location = new System.Drawing.Point(6, 43);
            this.FileTB.Name = "FileTB";
            this.FileTB.Size = new System.Drawing.Size(816, 386);
            this.FileTB.TabIndex = 1;
            this.FileTB.Text = "";
            // 
            // contextMenuForTextEditor
            // 
            this.contextMenuForTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyContextTool,
            this.CutOutContextTool,
            this.PasteContextTool,
            this.CancelContextTool,
            this.SelectAllContextTool});
            this.contextMenuForTextEditor.Name = "contextMenu";
            this.contextMenuForTextEditor.Size = new System.Drawing.Size(121, 114);
            // 
            // CopyContextTool
            // 
            this.CopyContextTool.Name = "CopyContextTool";
            this.CopyContextTool.Size = new System.Drawing.Size(120, 22);
            this.CopyContextTool.Text = "Copy";
            this.CopyContextTool.Click += new System.EventHandler(this.CopyContextTool_Click);
            // 
            // CutOutContextTool
            // 
            this.CutOutContextTool.Name = "CutOutContextTool";
            this.CutOutContextTool.Size = new System.Drawing.Size(120, 22);
            this.CutOutContextTool.Text = "Cut out";
            this.CutOutContextTool.Click += new System.EventHandler(this.CutOutContextTool_Click);
            // 
            // PasteContextTool
            // 
            this.PasteContextTool.Name = "PasteContextTool";
            this.PasteContextTool.Size = new System.Drawing.Size(120, 22);
            this.PasteContextTool.Text = "Paste";
            this.PasteContextTool.Click += new System.EventHandler(this.PasteContextTool_Click);
            // 
            // CancelContextTool
            // 
            this.CancelContextTool.Name = "CancelContextTool";
            this.CancelContextTool.Size = new System.Drawing.Size(120, 22);
            this.CancelContextTool.Text = "Cancel";
            this.CancelContextTool.Click += new System.EventHandler(this.CancelContextTool_Click);
            // 
            // SelectAllContextTool
            // 
            this.SelectAllContextTool.Name = "SelectAllContextTool";
            this.SelectAllContextTool.Size = new System.Drawing.Size(120, 22);
            this.SelectAllContextTool.Text = "Select all";
            this.SelectAllContextTool.Click += new System.EventHandler(this.SelectAllContextTool_Click);
            // 
            // menuForTextEditor
            // 
            this.menuForTextEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTool,
            this.settingsToolStripMenuItem});
            this.menuForTextEditor.Location = new System.Drawing.Point(3, 3);
            this.menuForTextEditor.Name = "menuForTextEditor";
            this.menuForTextEditor.Size = new System.Drawing.Size(850, 24);
            this.menuForTextEditor.TabIndex = 0;
            this.menuForTextEditor.Text = "menuStrip1";
            // 
            // FileTool
            // 
            this.FileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileTool,
            this.SaveFileTool,
            this.NewFileTool});
            this.FileTool.Name = "FileTool";
            this.FileTool.Size = new System.Drawing.Size(37, 20);
            this.FileTool.Text = "File";
            // 
            // OpenFileTool
            // 
            this.OpenFileTool.Name = "OpenFileTool";
            this.OpenFileTool.Size = new System.Drawing.Size(103, 22);
            this.OpenFileTool.Text = "Open";
            this.OpenFileTool.Click += new System.EventHandler(this.OpenFileTool_Click);
            // 
            // SaveFileTool
            // 
            this.SaveFileTool.Name = "SaveFileTool";
            this.SaveFileTool.Size = new System.Drawing.Size(103, 22);
            this.SaveFileTool.Text = "Save";
            this.SaveFileTool.Click += new System.EventHandler(this.SaveFileTool_Click);
            // 
            // NewFileTool
            // 
            this.NewFileTool.Name = "NewFileTool";
            this.NewFileTool.Size = new System.Drawing.Size(103, 22);
            this.NewFileTool.Text = "New";
            this.NewFileTool.Click += new System.EventHandler(this.NewFileTool_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontColorFileTool,
            this.BackColorFileTool,
            this.FontFileTool});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // FontColorFileTool
            // 
            this.FontColorFileTool.Name = "FontColorFileTool";
            this.FontColorFileTool.Size = new System.Drawing.Size(168, 22);
            this.FontColorFileTool.Text = "Font color";
            this.FontColorFileTool.Click += new System.EventHandler(this.FontColorFileTool_Click);
            // 
            // BackColorFileTool
            // 
            this.BackColorFileTool.Name = "BackColorFileTool";
            this.BackColorFileTool.Size = new System.Drawing.Size(168, 22);
            this.BackColorFileTool.Text = "Background color";
            this.BackColorFileTool.Click += new System.EventHandler(this.BackColorFileTool_Click);
            // 
            // FontFileTool
            // 
            this.FontFileTool.Name = "FontFileTool";
            this.FontFileTool.Size = new System.Drawing.Size(168, 22);
            this.FontFileTool.Text = "Font";
            this.FontFileTool.Click += new System.EventHandler(this.FontFileTool_Click);
            // 
            // SecondHWTask
            // 
            this.SecondHWTask.Controls.Add(this.toolStripForExplorer);
            this.SecondHWTask.Controls.Add(this.DirsLB);
            this.SecondHWTask.Controls.Add(this.DrivesLB);
            this.SecondHWTask.Controls.Add(this.menuForExplorer);
            this.SecondHWTask.Location = new System.Drawing.Point(4, 24);
            this.SecondHWTask.Name = "SecondHWTask";
            this.SecondHWTask.Padding = new System.Windows.Forms.Padding(3);
            this.SecondHWTask.Size = new System.Drawing.Size(856, 464);
            this.SecondHWTask.TabIndex = 1;
            this.SecondHWTask.Text = "Task 2";
            this.SecondHWTask.UseVisualStyleBackColor = true;
            // 
            // toolStripForExplorer
            // 
            this.toolStripForExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripForExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrivesLabelForExp,
            this.DirsLabelForExp});
            this.toolStripForExplorer.Location = new System.Drawing.Point(3, 436);
            this.toolStripForExplorer.Name = "toolStripForExplorer";
            this.toolStripForExplorer.Size = new System.Drawing.Size(850, 25);
            this.toolStripForExplorer.TabIndex = 3;
            this.toolStripForExplorer.Text = "toolStrip1";
            // 
            // DrivesLabelForExp
            // 
            this.DrivesLabelForExp.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.DrivesLabelForExp.Name = "DrivesLabelForExp";
            this.DrivesLabelForExp.Size = new System.Drawing.Size(67, 22);
            this.DrivesLabelForExp.Text = "Elements: 0";
            // 
            // DirsLabelForExp
            // 
            this.DirsLabelForExp.Margin = new System.Windows.Forms.Padding(220, 1, 0, 2);
            this.DirsLabelForExp.Name = "DirsLabelForExp";
            this.DirsLabelForExp.Size = new System.Drawing.Size(67, 22);
            this.DirsLabelForExp.Text = "Elements: 0";
            // 
            // DirsLB
            // 
            this.DirsLB.FormattingEnabled = true;
            this.DirsLB.ItemHeight = 15;
            this.DirsLB.Location = new System.Drawing.Point(298, 46);
            this.DirsLB.Name = "DirsLB";
            this.DirsLB.Size = new System.Drawing.Size(534, 379);
            this.DirsLB.TabIndex = 2;
            this.DirsLB.Click += new System.EventHandler(this.DirsLB_Click);
            // 
            // DrivesLB
            // 
            this.DrivesLB.FormattingEnabled = true;
            this.DrivesLB.ItemHeight = 15;
            this.DrivesLB.Location = new System.Drawing.Point(15, 46);
            this.DrivesLB.Name = "DrivesLB";
            this.DrivesLB.Size = new System.Drawing.Size(262, 379);
            this.DrivesLB.TabIndex = 1;
            this.DrivesLB.Click += new System.EventHandler(this.DrivesLB_Click);
            this.DrivesLB.DoubleClick += new System.EventHandler(this.DrivesLB_DoubleClick);
            // 
            // menuForExplorer
            // 
            this.menuForExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolExp,
            this.MainToolExp,
            this.SearchIcon,
            this.PathTB});
            this.menuForExplorer.Location = new System.Drawing.Point(3, 3);
            this.menuForExplorer.Name = "menuForExplorer";
            this.menuForExplorer.Size = new System.Drawing.Size(850, 27);
            this.menuForExplorer.TabIndex = 0;
            this.menuForExplorer.Text = "menuStrip1";
            // 
            // BackToolExp
            // 
            this.BackToolExp.Image = ((System.Drawing.Image)(resources.GetObject("BackToolExp.Image")));
            this.BackToolExp.Name = "BackToolExp";
            this.BackToolExp.Size = new System.Drawing.Size(28, 23);
            this.BackToolExp.Click += new System.EventHandler(this.BackToolExp_Click);
            // 
            // MainToolExp
            // 
            this.MainToolExp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolForExp,
            this.BackToolStripForExp});
            this.MainToolExp.Name = "MainToolExp";
            this.MainToolExp.Size = new System.Drawing.Size(46, 23);
            this.MainToolExp.Text = "Main";
            // 
            // OpenToolForExp
            // 
            this.OpenToolForExp.Name = "OpenToolForExp";
            this.OpenToolForExp.Size = new System.Drawing.Size(103, 22);
            this.OpenToolForExp.Text = "Open";
            this.OpenToolForExp.Click += new System.EventHandler(this.OpenToolForExp_Click);
            // 
            // BackToolStripForExp
            // 
            this.BackToolStripForExp.Name = "BackToolStripForExp";
            this.BackToolStripForExp.Size = new System.Drawing.Size(103, 22);
            this.BackToolStripForExp.Text = "Back";
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(28, 23);
            // 
            // PathTB
            // 
            this.PathTB.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.PathTB.Name = "PathTB";
            this.PathTB.Size = new System.Drawing.Size(612, 23);
            // 
            // ThirdHWTask
            // 
            this.ThirdHWTask.Location = new System.Drawing.Point(4, 24);
            this.ThirdHWTask.Name = "ThirdHWTask";
            this.ThirdHWTask.Size = new System.Drawing.Size(856, 464);
            this.ThirdHWTask.TabIndex = 2;
            this.ThirdHWTask.Text = "Task 3";
            this.ThirdHWTask.UseVisualStyleBackColor = true;
            // 
            // contextMenuForExplorer
            // 
            this.contextMenuForExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenContextForExp,
            this.BackContextForExp});
            this.contextMenuForExplorer.Name = "contextMenuForExplorer";
            this.contextMenuForExplorer.Size = new System.Drawing.Size(181, 70);
            // 
            // OpenContextForExp
            // 
            this.OpenContextForExp.Name = "OpenContextForExp";
            this.OpenContextForExp.Size = new System.Drawing.Size(180, 22);
            this.OpenContextForExp.Tag = "";
            this.OpenContextForExp.Text = "Open";
            this.OpenContextForExp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            // 
            // BackContextForExp
            // 
            this.BackContextForExp.Name = "BackContextForExp";
            this.BackContextForExp.Size = new System.Drawing.Size(180, 22);
            this.BackContextForExp.Text = "Back";
            this.BackContextForExp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 556);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.menuForTextEditor;
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
            this.FirstHWTask.ResumeLayout(false);
            this.FirstHWTask.PerformLayout();
            this.contextMenuForTextEditor.ResumeLayout(false);
            this.menuForTextEditor.ResumeLayout(false);
            this.menuForTextEditor.PerformLayout();
            this.SecondHWTask.ResumeLayout(false);
            this.SecondHWTask.PerformLayout();
            this.toolStripForExplorer.ResumeLayout(false);
            this.toolStripForExplorer.PerformLayout();
            this.menuForExplorer.ResumeLayout(false);
            this.menuForExplorer.PerformLayout();
            this.contextMenuForExplorer.ResumeLayout(false);
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
        private MenuStrip menuForTextEditor;
        private ToolStripMenuItem FileTool;
        private ToolStripMenuItem OpenFileTool;
        private ToolStripMenuItem SaveFileTool;
        private ToolStripMenuItem NewFileTool;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem FontColorFileTool;
        private ToolStripMenuItem BackColorFileTool;
        private ToolStripMenuItem FontFileTool;
        private RichTextBox FileTB;
        private ContextMenuStrip contextMenuForTextEditor;
        private ToolStripMenuItem CopyContextTool;
        private ToolStripMenuItem CutOutContextTool;
        private ToolStripMenuItem PasteContextTool;
        private ToolStripMenuItem CancelContextTool;
        private ToolStripMenuItem SelectAllContextTool;
        private MenuStrip menuForExplorer;
        private ContextMenuStrip contextMenuForExplorer;
        private ToolStripMenuItem BackToolExp;
        private ToolStripMenuItem MainToolExp;
        private ToolStripTextBox PathTB;
        private ListBox DirsLB;
        private ListBox DrivesLB;
        private ToolStrip toolStripForExplorer;
        private ToolStripLabel DrivesLabelForExp;
        private ToolStripLabel DirsLabelForExp;
        private ToolStripMenuItem SearchIcon;
        private ToolStripMenuItem OpenToolForExp;
        private ToolStripMenuItem BackToolStripForExp;
        private ToolStripMenuItem OpenContextForExp;
        private ToolStripMenuItem BackContextForExp;
    }
}