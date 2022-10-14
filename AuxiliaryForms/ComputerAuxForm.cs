
namespace WindowsForms
{
    public partial class ComputerAuxForm : Form
    {
        Product product; bool trigger;
        public ComputerAuxForm() => InitializeComponent();
        public ComputerAuxForm (Product product, bool trigger)
        {
            this.product = product;
            this.trigger = trigger;
        }
        private void ComputerAuxForm_Load(object sender, EventArgs e)
        {
            if (!trigger)
            {
                Text = "Editing a product";
                NameTB.Text = product.Name;
                DescriptionTB.Text = product.Description;
                PriceTB.Text = product.Price.ToString();
                trigger = true;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (trigger)
            {
                if (NameTB.Text == "" || DescriptionTB.Text == "" || PriceTB.Text == "")
                {
                    MessageBox.Show("Fill all text boxes!", "Ou!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                product.Name = NameTB.Text;
                product.Description = DescriptionTB.Text;
                try
                {
                    if (double.Parse(PriceTB.Text) < 0)
                    {
                        MessageBox.Show("Price can`t be less than 0!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    product.Price = double.Parse(PriceTB.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong price!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
        private void CancelButton_Click(object sender, EventArgs e) => Close();
    }
}
