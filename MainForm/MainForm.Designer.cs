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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SecondTaskTab = new System.Windows.Forms.TabPage();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.AllPriceLabel = new System.Windows.Forms.Label();
            this.ShowNextForm = new System.Windows.Forms.Button();
            this.productsInStock = new System.Windows.Forms.ComboBox();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.menuStripTab2 = new System.Windows.Forms.MenuStrip();
            this.AddButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProductButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ThirdTaskTab = new System.Windows.Forms.TabPage();
            this.FileTB = new System.Windows.Forms.TextBox();
            this.menuStripTab3 = new System.Windows.Forms.MenuStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.FirstTaskTab.SuspendLayout();
            this.SecondTaskTab.SuspendLayout();
            this.menuStripTab2.SuspendLayout();
            this.ThirdTaskTab.SuspendLayout();
            this.menuStripTab3.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(891, 547);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // FirstTaskTab
            // 
            this.FirstTaskTab.Controls.Add(this.CloseButton);
            this.FirstTaskTab.Controls.Add(this.SearchButton);
            this.FirstTaskTab.Location = new System.Drawing.Point(4, 24);
            this.FirstTaskTab.Name = "FirstTaskTab";
            this.FirstTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTaskTab.Size = new System.Drawing.Size(883, 519);
            this.FirstTaskTab.TabIndex = 0;
            this.FirstTaskTab.Text = "First Task";
            this.FirstTaskTab.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(317, 200);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(156, 47);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(85, 200);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(153, 47);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SecondTaskTab
            // 
            this.SecondTaskTab.Controls.Add(this.groupBoxProduct);
            this.SecondTaskTab.Controls.Add(this.ProductPriceLabel);
            this.SecondTaskTab.Controls.Add(this.AllPriceLabel);
            this.SecondTaskTab.Controls.Add(this.ShowNextForm);
            this.SecondTaskTab.Controls.Add(this.productsInStock);
            this.SecondTaskTab.Controls.Add(this.ProductsListBox);
            this.SecondTaskTab.Controls.Add(this.menuStripTab2);
            this.SecondTaskTab.Location = new System.Drawing.Point(4, 24);
            this.SecondTaskTab.Name = "SecondTaskTab";
            this.SecondTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTaskTab.Size = new System.Drawing.Size(883, 519);
            this.SecondTaskTab.TabIndex = 1;
            this.SecondTaskTab.Text = "Second Task";
            this.SecondTaskTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Location = new System.Drawing.Point(32, 363);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(402, 130);
            this.groupBoxProduct.TabIndex = 6;
            this.groupBoxProduct.TabStop = false;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(85, 234);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(0, 15);
            this.ProductPriceLabel.TabIndex = 5;
            // 
            // AllPriceLabel
            // 
            this.AllPriceLabel.AutoSize = true;
            this.AllPriceLabel.Location = new System.Drawing.Point(85, 198);
            this.AllPriceLabel.Name = "AllPriceLabel";
            this.AllPriceLabel.Size = new System.Drawing.Size(0, 15);
            this.AllPriceLabel.TabIndex = 4;
            // 
            // ShowNextForm
            // 
            this.ShowNextForm.Location = new System.Drawing.Point(85, 275);
            this.ShowNextForm.Name = "ShowNextForm";
            this.ShowNextForm.Size = new System.Drawing.Size(253, 49);
            this.ShowNextForm.TabIndex = 3;
            this.ShowNextForm.Text = "Show next form";
            this.ShowNextForm.UseVisualStyleBackColor = true;
            this.ShowNextForm.Click += new System.EventHandler(this.ShowNextForm_Click);
            // 
            // productsInStock
            // 
            this.productsInStock.FormattingEnabled = true;
            this.productsInStock.Location = new System.Drawing.Point(85, 146);
            this.productsInStock.Name = "productsInStock";
            this.productsInStock.Size = new System.Drawing.Size(253, 23);
            this.productsInStock.TabIndex = 2;
            this.productsInStock.SelectedIndexChanged += new System.EventHandler(this.SelectedProductIndexChanged);
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 15;
            this.ProductsListBox.Location = new System.Drawing.Point(486, 36);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(380, 469);
            this.ProductsListBox.TabIndex = 0;
            // 
            // menuStripTab2
            // 
            this.menuStripTab2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.EditProductButton});
            this.menuStripTab2.Location = new System.Drawing.Point(3, 3);
            this.menuStripTab2.Name = "menuStripTab2";
            this.menuStripTab2.Size = new System.Drawing.Size(877, 24);
            this.menuStripTab2.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(41, 20);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(39, 20);
            this.EditProductButton.Text = "Edit";
            this.EditProductButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ThirdTaskTab
            // 
            this.ThirdTaskTab.Controls.Add(this.FileTB);
            this.ThirdTaskTab.Controls.Add(this.menuStripTab3);
            this.ThirdTaskTab.Location = new System.Drawing.Point(4, 24);
            this.ThirdTaskTab.Name = "ThirdTaskTab";
            this.ThirdTaskTab.Size = new System.Drawing.Size(883, 519);
            this.ThirdTaskTab.TabIndex = 2;
            this.ThirdTaskTab.Text = "Third Task";
            this.ThirdTaskTab.UseVisualStyleBackColor = true;
            // 
            // FileTB
            // 
            this.FileTB.Location = new System.Drawing.Point(74, 106);
            this.FileTB.Name = "FileTB";
            this.FileTB.ReadOnly = true;
            this.FileTB.Size = new System.Drawing.Size(394, 23);
            this.FileTB.TabIndex = 1;
            // 
            // menuStripTab3
            // 
            this.menuStripTab3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.EditFileButton});
            this.menuStripTab3.Location = new System.Drawing.Point(0, 0);
            this.menuStripTab3.Name = "menuStripTab3";
            this.menuStripTab3.Size = new System.Drawing.Size(883, 24);
            this.menuStripTab3.TabIndex = 0;
            this.menuStripTab3.Text = "menuStrip1";
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(45, 20);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // EditFileButton
            // 
            this.EditFileButton.Enabled = false;
            this.EditFileButton.Name = "EditFileButton";
            this.EditFileButton.Size = new System.Drawing.Size(39, 20);
            this.EditFileButton.Text = "Edit";
            this.EditFileButton.Click += new System.EventHandler(this.EditFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 571);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStripTab2;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.FirstTaskTab.ResumeLayout(false);
            this.SecondTaskTab.ResumeLayout(false);
            this.SecondTaskTab.PerformLayout();
            this.menuStripTab2.ResumeLayout(false);
            this.menuStripTab2.PerformLayout();
            this.ThirdTaskTab.ResumeLayout(false);
            this.ThirdTaskTab.PerformLayout();
            this.menuStripTab3.ResumeLayout(false);
            this.menuStripTab3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage FirstTaskTab;
        private TabPage SecondTaskTab;
        private TabPage ThirdTaskTab;
        private Button CloseButton;
        private Button SearchButton;
        private ListBox ProductsListBox;
        private Button ShowNextForm;
        private ComboBox productsInStock;
        private MenuStrip menuStripTab2;
        private ToolStripMenuItem AddButton;
        private ToolStripMenuItem EditProductButton;
        private Label AllPriceLabel;
        private Label ProductPriceLabel;
        private GroupBox groupBoxProduct;
        private MenuStrip menuStripTab3;
        private ToolStripMenuItem LoadButton;
        private ToolStripMenuItem EditFileButton;
        private TextBox FileTB;
    }
}