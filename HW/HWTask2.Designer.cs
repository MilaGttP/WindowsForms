namespace WindowsForms
{
    partial class QuestionaryForm
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
            this.PhoneTB = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailTB = new MaterialSkin.Controls.MaterialTextBox();
            this.SurnameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.NameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.ResetButton = new MaterialSkin.Controls.MaterialButton();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.OKButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // PhoneTB
            // 
            this.PhoneTB.AnimateReadOnly = false;
            this.PhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTB.Depth = 0;
            this.PhoneTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhoneTB.Hint = "Phone";
            this.PhoneTB.LeadingIcon = null;
            this.PhoneTB.Location = new System.Drawing.Point(32, 267);
            this.PhoneTB.MaxLength = 50;
            this.PhoneTB.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneTB.Multiline = false;
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(290, 50);
            this.PhoneTB.TabIndex = 11;
            this.PhoneTB.Text = "";
            this.PhoneTB.TrailingIcon = null;
            // 
            // EmailTB
            // 
            this.EmailTB.AnimateReadOnly = false;
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTB.Depth = 0;
            this.EmailTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailTB.Hint = "Email";
            this.EmailTB.LeadingIcon = null;
            this.EmailTB.Location = new System.Drawing.Point(32, 211);
            this.EmailTB.MaxLength = 50;
            this.EmailTB.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTB.Multiline = false;
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(290, 50);
            this.EmailTB.TabIndex = 10;
            this.EmailTB.Text = "";
            this.EmailTB.TrailingIcon = null;
            // 
            // SurnameTB
            // 
            this.SurnameTB.AnimateReadOnly = false;
            this.SurnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTB.Depth = 0;
            this.SurnameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SurnameTB.Hint = "Surname";
            this.SurnameTB.LeadingIcon = null;
            this.SurnameTB.Location = new System.Drawing.Point(32, 155);
            this.SurnameTB.MaxLength = 50;
            this.SurnameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.SurnameTB.Multiline = false;
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(290, 50);
            this.SurnameTB.TabIndex = 9;
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
            this.NameTB.Location = new System.Drawing.Point(32, 99);
            this.NameTB.MaxLength = 50;
            this.NameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.NameTB.Multiline = false;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(290, 50);
            this.NameTB.TabIndex = 8;
            this.NameTB.Text = "";
            this.NameTB.TrailingIcon = null;
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResetButton.Depth = 0;
            this.ResetButton.HighEmphasis = true;
            this.ResetButton.Icon = null;
            this.ResetButton.Location = new System.Drawing.Point(409, 203);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ResetButton.Size = new System.Drawing.Size(65, 36);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ResetButton.UseAccentColor = false;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BackButton.Depth = 0;
            this.BackButton.HighEmphasis = true;
            this.BackButton.Icon = null;
            this.BackButton.Location = new System.Drawing.Point(409, 267);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackButton.Name = "BackButton";
            this.BackButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BackButton.Size = new System.Drawing.Size(64, 36);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "BAck";
            this.BackButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BackButton.UseAccentColor = false;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OKButton.Depth = 0;
            this.OKButton.HighEmphasis = true;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(409, 137);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OKButton.Size = new System.Drawing.Size(64, 36);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKButton.UseAccentColor = false;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // QuestionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 380);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.SurnameTB);
            this.Name = "QuestionaryForm";
            this.Text = "Person questionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PhoneTB;
        private MaterialSkin.Controls.MaterialTextBox EmailTB;
        private MaterialSkin.Controls.MaterialTextBox SurnameTB;
        private MaterialSkin.Controls.MaterialTextBox NameTB;
        private MaterialSkin.Controls.MaterialButton ResetButton;
        private MaterialSkin.Controls.MaterialButton BackButton;
        private MaterialSkin.Controls.MaterialButton OKButton;
    }
}