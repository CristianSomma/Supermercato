using Supermercato_SOMMA.Managers;
using Supermercato_SOMMA.Models;

namespace Supermercato_SOMMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdminManager adminManager = new AdminManager();
            
            Product test = new(
                "a",
                ProductCategory.FrozenFood,
                12f,
                DateTime.Today,
                10
                );

            adminManager.AddProduct(test);

            Product newTestVersion = new(
                "A",
                ProductCategory.FreshFood,
                10.5f,
                DateTime.Today,
                10
                );

            adminManager.EditProduct(test, newTestVersion);

            return;
        }
    }
}