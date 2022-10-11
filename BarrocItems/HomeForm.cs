using BarrocItems.Finances;

namespace BarrocItems
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button to go to the invoiceMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPurchases_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }
    }
}