using Supermercato_SOMMA.Managers;
using Supermercato_SOMMA.Models;
using System.CodeDom;
using System.ComponentModel;

namespace Supermercato_SOMMA
{
    public partial class AdminForm : Form
    {
        private AdminManager _adminManager;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _adminManager = new AdminManager();
            Utilities.TableSetup(dtg_adminTable, _adminManager.Products);
            ChangePropertiesPanelsVisibility(VisibilityStatus.HideBoth);
            Utilities.ComboBoxSetup(cmb_productCategory, Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToArray());
        }

        private void mni_AddProduct_Click(object sender, EventArgs e)
        {
            ChangePropertiesPanelsVisibility(VisibilityStatus.HideBoth);
        }

        private void mni_foodProduct_Click(object sender, EventArgs e)
        {
            ChangePropertiesPanelsVisibility(VisibilityStatus.ShowFoodProperties);
        }

        private void mni_nonFoodProduct_Click(object sender, EventArgs e)
        {
            ChangePropertiesPanelsVisibility(VisibilityStatus.ShowNonFoodProperties);
        }

        private void btn_AddFoodProduct_Click(object sender, EventArgs e)
        {
            if (!AreInputsValid())
                return;

            FoodProduct? newProduct = Utilities.CreateProduct(
                GetProductOptions(),
                (float)(nmr_productWeight.Value),
                dtm_productExpiringDate.Value);

            if (newProduct != null)
                _adminManager.AddProduct(newProduct);

            Utilities.ResetAllInputFields(pnl_addControlsContainer);
            ChangePropertiesPanelsVisibility(VisibilityStatus.HideBoth);
        }

        private void btn_addNonFoodProduct_Click(object sender, EventArgs e)
        {
            if (!AreInputsValid())
                return;

            NonFoodProduct? newProduct = Utilities.CreateProduct(
                GetProductOptions(),
                chc_productFragile.Checked,
                (uint)nmr_productAgeRestriction.Value
                );

            if (newProduct != null)
                _adminManager.AddProduct(newProduct);

            Utilities.ResetAllInputFields(pnl_addControlsContainer);
            ChangePropertiesPanelsVisibility(VisibilityStatus.HideBoth);
        }

        private void chc_productIsDiscounted_CheckedChanged(object sender, EventArgs e)
        {
            bool discountPercentageVisible = true;

            if (!chc_productIsDiscounted.Checked)
                discountPercentageVisible = false;

            lbl_productDiscountPercentage.Visible = discountPercentageVisible;
            nmr_productDiscountPercentage.Visible = discountPercentageVisible;
        }

        private bool AreInputsValid()
        {
            if (string.IsNullOrWhiteSpace(txt_productName.Text))
            {
                Utilities.SetTextInputFeedback(txt_productName);
                MessageBox.Show(
                    "The name field cannot be empty or just whitespaces.",
                    "PRODUCT NAME NOT VALID",
                    MessageBoxButtons.OK
                    );
                return false;
            }

            if (cmb_productCategory.SelectedIndex == 0)
            {
                Utilities.SetTextInputFeedback(cmb_productCategory);
                MessageBox.Show(
                    "Select a category of product",
                    "PRODUCT CATEGORY NOT VALID",
                    MessageBoxButtons.OK
                    );
                return false;
            }

            return true;
        }

        private ProductOptions GetProductOptions()
        {

            string name = txt_productName.Text.ToUpper();
            string? brand = (txt_productBrand.Text == "")
                ? null
                : txt_productBrand.Text.ToUpper();

            ProductCategory category = (ProductCategory)(cmb_productCategory.SelectedItem is null
                ? ProductCategory.SelectCategory
                : cmb_productCategory.SelectedItem);

            float price = (float)(nmr_productPrice.Value);

            uint discountPercentage = (uint)(chc_productIsDiscounted.Checked
                ? nmr_productDiscountPercentage.Value
                : 0);
            uint stock = (uint)(nmr_productStock.Value);

            ProductOptions newProductOptions = new ProductOptions()
            {
                Name = name,
                Brand = brand,
                Category = category,
                Price = price,
                DiscountPercentage = discountPercentage,
                Stock = stock
            };

            return newProductOptions;
        }

        private void cmb_productCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmb_productCategory.SelectedIndex;

            if (selectedIndex > 0 && selectedIndex < 4)
                mni_foodProduct_Click(mni_foodProduct, e);
            else if (selectedIndex >= 4 && selectedIndex <= 7)
                mni_nonFoodProduct_Click(mni_nonFoodProduct, e);
        }

        private void ChangePropertiesPanelsVisibility(VisibilityStatus visibility)
        {
            Utilities.SetPropertiesBoxVisibility(
                visibility,
                new Control[] { lbl_foodProperties, pnl_foodProperties, btn_AddFoodProduct },
                new Control[] { lbl_nonFoodProperties, pnl_nonFoodProperties, btn_addNonFoodProduct }
                );
        }

    }

}