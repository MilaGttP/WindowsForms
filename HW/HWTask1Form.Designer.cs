namespace WindowsForms
{
    partial class HWTask1Form
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
            this.SurnameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.NameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.PatronymicTB = new MaterialSkin.Controls.MaterialTextBox();
            this.GenderTB = new MaterialSkin.Controls.MaterialTextBox();
            this.FamilyStatTB = new MaterialSkin.Controls.MaterialTextBox();
            this.AuxInfTB = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.ResetButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // SurnameTB
            // 
            this.SurnameTB.AnimateReadOnly = false;
            this.SurnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTB.Depth = 0;
            this.SurnameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurnameTB.Hint = "Surname";
            this.SurnameTB.LeadingIcon = null;
            this.SurnameTB.Location = new System.Drawing.Point(33, 91);
            this.SurnameTB.MaxLength = 50;
            this.SurnameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.SurnameTB.Multiline = false;
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(237, 50);
            this.SurnameTB.TabIndex = 0;
            this.SurnameTB.Text = "";
            this.SurnameTB.TrailingIcon = null;
            // 
            // NameTB
            // 
            this.NameTB.AnimateReadOnly = false;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Depth = 0;
            this.NameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameTB.Hint = "Name";
            this.NameTB.LeadingIcon = null;
            this.NameTB.Location = new System.Drawing.Point(33, 147);
            this.NameTB.MaxLength = 50;
            this.NameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.NameTB.Multiline = false;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(237, 50);
            this.NameTB.TabIndex = 1;
            this.NameTB.Text = "";
            this.NameTB.TrailingIcon = null;
            // 
            // PatronymicTB
            // 
            this.PatronymicTB.AnimateReadOnly = false;
            this.PatronymicTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatronymicTB.Depth = 0;
            this.PatronymicTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PatronymicTB.Hint = "Patronymic";
            this.PatronymicTB.LeadingIcon = null;
            this.PatronymicTB.Location = new System.Drawing.Point(33, 203);
            this.PatronymicTB.MaxLength = 50;
            this.PatronymicTB.MouseState = MaterialSkin.MouseState.OUT;
            this.PatronymicTB.Multiline = false;
            this.PatronymicTB.Name = "PatronymicTB";
            this.PatronymicTB.Size = new System.Drawing.Size(237, 50);
            this.PatronymicTB.TabIndex = 2;
            this.PatronymicTB.Text = "";
            this.PatronymicTB.TrailingIcon = null;
            // 
            // GenderTB
            // 
            this.GenderTB.AnimateReadOnly = false;
            this.GenderTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenderTB.Depth = 0;
            this.GenderTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GenderTB.Hint = "Gender";
            this.GenderTB.LeadingIcon = null;
            this.GenderTB.Location = new System.Drawing.Point(33, 259);
            this.GenderTB.MaxLength = 50;
            this.GenderTB.MouseState = MaterialSkin.MouseState.OUT;
            this.GenderTB.Multiline = false;
            this.GenderTB.Name = "GenderTB";
            this.GenderTB.Size = new System.Drawing.Size(237, 50);
            this.GenderTB.TabIndex = 3;
            this.GenderTB.Text = "";
            this.GenderTB.TrailingIcon = null;
            // 
            // FamilyStatTB
            // 
            this.FamilyStatTB.AnimateReadOnly = false;
            this.FamilyStatTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FamilyStatTB.Depth = 0;
            this.FamilyStatTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FamilyStatTB.Hint = "Family status";
            this.FamilyStatTB.LeadingIcon = null;
            this.FamilyStatTB.Location = new System.Drawing.Point(33, 315);
            this.FamilyStatTB.MaxLength = 50;
            this.FamilyStatTB.MouseState = MaterialSkin.MouseState.OUT;
            this.FamilyStatTB.Multiline = false;
            this.FamilyStatTB.Name = "FamilyStatTB";
            this.FamilyStatTB.Size = new System.Drawing.Size(237, 50);
            this.FamilyStatTB.TabIndex = 5;
            this.FamilyStatTB.Text = "";
            this.FamilyStatTB.TrailingIcon = null;
            // 
            // AuxInfTB
            // 
            this.AuxInfTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuxInfTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuxInfTB.Depth = 0;
            this.AuxInfTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AuxInfTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AuxInfTB.Hint = "Auxiliary information";
            this.AuxInfTB.Location = new System.Drawing.Point(350, 117);
            this.AuxInfTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AuxInfTB.Name = "AuxInfTB";
            this.AuxInfTB.Size = new System.Drawing.Size(243, 96);
            this.AuxInfTB.TabIndex = 6;
            this.AuxInfTB.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(350, 256);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(243, 23);
            this.dateTimePicker.TabIndex = 7;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(350, 234);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(158, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Year and date of birth:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(350, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(153, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Auxiliary information:";
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(387, 315);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveButton.Size = new System.Drawing.Size(64, 36);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResetButton.Depth = 0;
            this.ResetButton.HighEmphasis = true;
            this.ResetButton.Icon = null;
            this.ResetButton.Location = new System.Drawing.Point(488, 315);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ResetButton.Size = new System.Drawing.Size(65, 36);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ResetButton.UseAccentColor = false;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HWTask1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AuxInfTB);
            this.Controls.Add(this.FamilyStatTB);
            this.Controls.Add(this.GenderTB);
            this.Controls.Add(this.PatronymicTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.SurnameTB);
            this.Name = "HWTask1Form";
            this.Text = "Person information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox SurnameTB;
        private MaterialSkin.Controls.MaterialTextBox NameTB;
        private MaterialSkin.Controls.MaterialTextBox PatronymicTB;
        private MaterialSkin.Controls.MaterialTextBox GenderTB;
        private MaterialSkin.Controls.MaterialTextBox FamilyStatTB;
        private MaterialSkin.Controls.MaterialMultiLineTextBox AuxInfTB;
        private DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialButton ResetButton;
    }
}