namespace WindowsForms
{
    partial class EditingTextAuxForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingTB = new MaterialSkin.Controls.MaterialTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.CancelButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(578, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 20);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(55, 20);
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditingTB
            // 
            this.EditingTB.AnimateReadOnly = false;
            this.EditingTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditingTB.Depth = 0;
            this.EditingTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EditingTB.Hint = "Edit";
            this.EditingTB.LeadingIcon = null;
            this.EditingTB.Location = new System.Drawing.Point(44, 73);
            this.EditingTB.MaxLength = 50;
            this.EditingTB.MouseState = MaterialSkin.MouseState.OUT;
            this.EditingTB.Multiline = false;
            this.EditingTB.Name = "EditingTB";
            this.EditingTB.Size = new System.Drawing.Size(405, 50);
            this.EditingTB.TabIndex = 1;
            this.EditingTB.Text = "";
            this.EditingTB.TrailingIcon = null;
            // 
            // EditingTextAuxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 329);
            this.Controls.Add(this.EditingTB);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditingTextAuxForm";
            this.Text = "EditingTextAuxForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem CancelButton;
        private MaterialSkin.Controls.MaterialTextBox EditingTB;
    }
}