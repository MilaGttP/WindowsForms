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
            this.label5 = new System.Windows.Forms.Label();
            this.WorkersListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HouseCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StreetCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionCB = new System.Windows.Forms.ComboBox();
            this.SalaryTB = new MaterialSkin.Controls.MaterialTextBox();
            this.SurnameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondTabTask = new System.Windows.Forms.TabPage();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl.SuspendLayout();
            this.FirstTaskTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SecondTabTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.FirstTaskTab);
            this.tabControl.Controls.Add(this.SecondTabTask);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 462);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedTabIndex);
            // 
            // FirstTaskTab
            // 
            this.FirstTaskTab.Controls.Add(this.label5);
            this.FirstTaskTab.Controls.Add(this.WorkersListBox);
            this.FirstTaskTab.Controls.Add(this.label4);
            this.FirstTaskTab.Controls.Add(this.HouseCB);
            this.FirstTaskTab.Controls.Add(this.label3);
            this.FirstTaskTab.Controls.Add(this.StreetCB);
            this.FirstTaskTab.Controls.Add(this.label2);
            this.FirstTaskTab.Controls.Add(this.CityCB);
            this.FirstTaskTab.Controls.Add(this.label1);
            this.FirstTaskTab.Controls.Add(this.PositionCB);
            this.FirstTaskTab.Controls.Add(this.SalaryTB);
            this.FirstTaskTab.Controls.Add(this.SurnameTB);
            this.FirstTaskTab.Controls.Add(this.menuStrip1);
            this.FirstTaskTab.Location = new System.Drawing.Point(4, 24);
            this.FirstTaskTab.Name = "FirstTaskTab";
            this.FirstTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTaskTab.Size = new System.Drawing.Size(830, 434);
            this.FirstTaskTab.TabIndex = 0;
            this.FirstTaskTab.Text = "First Task";
            this.FirstTaskTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Workers list";
            // 
            // WorkersListBox
            // 
            this.WorkersListBox.FormattingEnabled = true;
            this.WorkersListBox.ItemHeight = 15;
            this.WorkersListBox.Location = new System.Drawing.Point(441, 68);
            this.WorkersListBox.Name = "WorkersListBox";
            this.WorkersListBox.Size = new System.Drawing.Size(347, 319);
            this.WorkersListBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "House:";
            // 
            // HouseCB
            // 
            this.HouseCB.FormattingEnabled = true;
            this.HouseCB.Location = new System.Drawing.Point(34, 364);
            this.HouseCB.Name = "HouseCB";
            this.HouseCB.Size = new System.Drawing.Size(337, 23);
            this.HouseCB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Street:";
            // 
            // StreetCB
            // 
            this.StreetCB.FormattingEnabled = true;
            this.StreetCB.Location = new System.Drawing.Point(34, 305);
            this.StreetCB.Name = "StreetCB";
            this.StreetCB.Size = new System.Drawing.Size(337, 23);
            this.StreetCB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "City:";
            // 
            // CityCB
            // 
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(34, 245);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(337, 23);
            this.CityCB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Position:";
            // 
            // PositionCB
            // 
            this.PositionCB.FormattingEnabled = true;
            this.PositionCB.Location = new System.Drawing.Point(34, 187);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(337, 23);
            this.PositionCB.TabIndex = 2;
            // 
            // SalaryTB
            // 
            this.SalaryTB.AnimateReadOnly = false;
            this.SalaryTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalaryTB.Depth = 0;
            this.SalaryTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalaryTB.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SalaryTB.Hint = "Salary";
            this.SalaryTB.LeadingIcon = null;
            this.SalaryTB.Location = new System.Drawing.Point(34, 106);
            this.SalaryTB.MaxLength = 50;
            this.SalaryTB.MouseState = MaterialSkin.MouseState.OUT;
            this.SalaryTB.Multiline = false;
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(337, 50);
            this.SalaryTB.TabIndex = 1;
            this.SalaryTB.Text = "";
            this.SalaryTB.TrailingIcon = null;
            // 
            // SurnameTB
            // 
            this.SurnameTB.AnimateReadOnly = false;
            this.SurnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTB.Depth = 0;
            this.SurnameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurnameTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SurnameTB.Hint = "Surname";
            this.SurnameTB.LeadingIcon = null;
            this.SurnameTB.Location = new System.Drawing.Point(34, 50);
            this.SurnameTB.MaxLength = 50;
            this.SurnameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.SurnameTB.Multiline = false;
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(337, 50);
            this.SurnameTB.TabIndex = 0;
            this.SurnameTB.Text = "";
            this.SurnameTB.TrailingIcon = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.ResetButton,
            this.SaveButton,
            this.LoadButton});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddButton
            // 
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(41, 20);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(47, 20);
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 20);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(45, 20);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SecondTabTask
            // 
            this.SecondTabTask.Controls.Add(this.StartButton);
            this.SecondTabTask.Controls.Add(this.progressBar);
            this.SecondTabTask.Location = new System.Drawing.Point(4, 24);
            this.SecondTabTask.Name = "SecondTabTask";
            this.SecondTabTask.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTabTask.Size = new System.Drawing.Size(830, 434);
            this.SecondTabTask.TabIndex = 1;
            this.SecondTabTask.Text = "Second Task";
            this.SecondTabTask.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartButton.Depth = 0;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(55, 201);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartButton.Size = new System.Drawing.Size(67, 36);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(55, 149);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(407, 23);
            this.progressBar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 487);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.FirstTaskTab.ResumeLayout(false);
            this.FirstTaskTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SecondTabTask.ResumeLayout(false);
            this.SecondTabTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage FirstTaskTab;
        private TabPage SecondTabTask;
        private Label label4;
        private ComboBox HouseCB;
        private Label label3;
        private ComboBox StreetCB;
        private Label label2;
        private ComboBox CityCB;
        private Label label1;
        private ComboBox PositionCB;
        private MaterialSkin.Controls.MaterialTextBox SalaryTB;
        private MaterialSkin.Controls.MaterialTextBox SurnameTB;
        private Label label5;
        private ListBox WorkersListBox;
        private MaterialSkin.Controls.MaterialButton StartButton;
        private ProgressBar progressBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddButton;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem LoadButton;
        private ToolStripMenuItem ResetButton;
    }
}