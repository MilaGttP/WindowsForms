
using System.Text;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            FileSearchingAuxForm auxForm = new FileSearchingAuxForm();
            auxForm.Show();
        }
        private void CloseButton_Click(object sender, EventArgs e) => Close();

        public double GeneralPrice { get; set; } = 0;
        List <Product> productsList = null;

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1) productsList = new List<Product>();
            else if (tabControl.SelectedIndex == 2) TextBoxReading = "";
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try {
                ProductsListBox.Items.Add(((Product)productsInStock.Items[productsInStock.SelectedIndex]).ToString());
                GeneralPrice += ((Product)productsInStock.Items[productsInStock.SelectedIndex]).Price;
                if (ProductsListBox.Items.Count > 0)
                {
                    AllPriceLabel.Visible = true;
                    ProductPriceLabel.Visible = true;
                }
                ProductPriceLabel.Text = GeneralPrice.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ou!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void SelectedProductIndexChanged(object sender, EventArgs e)
        {
            ProductPriceLabel.Text = ((Product)productsInStock.Items[productsInStock.SelectedIndex]).Price.ToString();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            try {
                int tmpIndex = productsInStock.SelectedIndex;
                Product tempProduct = (Product)productsInStock.Items[tmpIndex];
                ComputerAuxForm auxForm = new ComputerAuxForm(tempProduct, false);
                auxForm.ShowDialog();
                productsInStock.Items.RemoveAt(tmpIndex);
                productsInStock.Items.Insert(tmpIndex, tempProduct);
                productsInStock.SelectedIndex = tmpIndex;
            }
            catch (Exception)
            {
                MessageBox.Show("You hadn`t selected item!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ShowNextForm_Click(object sender, EventArgs e)
        {
            productsList.Add(new Product());
            ComputerAuxForm auxForm = new ComputerAuxForm(productsList[productsList.Count - 1], true);
            if (auxForm.ShowDialog() == DialogResult.OK)
            {
                productsInStock.Items.Add(productsList[productsList.Count - 1]);
                groupBoxProduct.Text = $"In stock: {productsInStock.Items.Count}";
            }
        }

        public string TextBoxReading
        {
            get { return FileTB.Text; }
            set { FileTB.Text = value; }
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.FileName, Encoding.Default);
                FileTB.Clear();
                FileTB.Text = reader.ReadToEnd();
                reader.Close();
                EditFileButton.Enabled = true;
            }
        }
        private void EditFileButton_Click(object sender, EventArgs e)
        {
            EditingTextAuxForm auxForm = new EditingTextAuxForm(this);
            auxForm.Show();
        }
    }
}