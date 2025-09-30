using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercato_SOMMA.Managers
{
    public partial class ClientForm : Form
    {
        private ClientManager _clientManager;
        private VisualManager _visualManager;
        private BindingList<Product> _products;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            _products = new BindingList<Product>();
            FileManager fileManager = new FileManager("../products.json");
            fileManager.DeserializeProducts(_products);
            _clientManager = new ClientManager();
            _visualManager = new VisualManager(this);
            _visualManager.TableSetup(dtg_clientTable, _products);
            _visualManager.ComboBoxSetup(cmb_selectedProduct, _products, "Name", -1);

            if (_products.Count == 0)
                _visualManager.SetControlStatus(true, btn_addProduct, btn_pay);
        }

        private void btn_adminDashboard_Click(object sender, EventArgs e)
        {
            AdminForm adminDashboard = new AdminForm(_products);

            adminDashboard.ShowDialog();

            bool areDisabled = true;
            if (_products.Count > 0)
                areDisabled = false;

            _visualManager.SetControlStatus(areDisabled, btn_pay, btn_addProduct);
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = _products[cmb_selectedProduct.SelectedIndex];

            float total = float.Parse(lbl_totalPrice.Text);
            float totalPrice = _clientManager.AddProduct(selectedProduct, (uint)(nmr_productQuantity.Value), total);

            lbl_totalPrice.Text = totalPrice.ToString("F2");
            nmr_productQuantity.Value = 1;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            PrintDocument documentPrint = new PrintDocument();

            documentPrint.PrintPage += (s, e) =>
            {
                e.Graphics.DrawString(
                GetString(),
                new Font("Consolas", 10),
                Brushes.Black,
                new PointF(10, 10)
                );
            };

            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = documentPrint;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                documentPrint.Print(); 
            }
        }

        private string GetString()
        {
            string printingText =
$@"========================================
               SUPERMARKET
========================================
Data: {DateTime.Today:dd/MM/yyyy}                        
----------------------------------------
Prodotto          Qtà    Prezzo
----------------------------------------
";

            foreach (var tuple in _clientManager.OrderedProducts)
            {
                string line = tuple.Product.Name.PadRight(20) +
                              tuple.Quantity.ToString().PadRight(6) +
                              $"€ {tuple.Product.Price:0.00}";

                printingText += $"{line}\n";
            }

            printingText += $@"----------------------------------------
Totale:                          € {lbl_totalPrice.Text}
========================================
      Grazie per averci scelto!
========================================";

            return printingText;
        }
    }
}
