namespace WindowsForms
{
    partial class FileSearchingAuxForm
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
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.ExtensionTB = new MaterialSkin.Controls.MaterialTextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileListBox
            // 
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.ItemHeight = 15;
            this.FileListBox.Location = new System.Drawing.Point(429, 35);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(634, 394);
            this.FileListBox.TabIndex = 0;
            // 
            // ExtensionTB
            // 
            this.ExtensionTB.AnimateReadOnly = false;
            this.ExtensionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtensionTB.Depth = 0;
            this.ExtensionTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ExtensionTB.Hint = "Extension";
            this.ExtensionTB.LeadingIcon = null;
            this.ExtensionTB.Location = new System.Drawing.Point(74, 126);
            this.ExtensionTB.MaxLength = 50;
            this.ExtensionTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ExtensionTB.Multiline = false;
            this.ExtensionTB.Name = "ExtensionTB";
            this.ExtensionTB.Size = new System.Drawing.Size(254, 50);
            this.ExtensionTB.TabIndex = 2;
            this.ExtensionTB.Text = "";
            this.ExtensionTB.TrailingIcon = null;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(74, 218);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(254, 50);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FileSearchingAuxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 446);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ExtensionTB);
            this.Controls.Add(this.FileListBox);
            this.Name = "FileSearchingAuxForm";
            this.Text = "FileSearchingAuxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox FileListBox;
        private MaterialSkin.Controls.MaterialTextBox ExtensionTB;
        private Button OKButton;
    }
}