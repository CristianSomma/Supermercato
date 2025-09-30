using Supermercato_SOMMA.Managers;
using Supermercato_SOMMA.Models;
using System.CodeDom;
using System.ComponentModel;
using System.Globalization;

namespace Supermercato_SOMMA
{
    public partial class AdminForm : Form
    {
        private AdminManager _adminManager;
        private VisualManager _visualManager;

        public AdminForm(BindingList<Product> productsList)
        {
            InitializeComponent();
            _adminManager = new AdminManager(productsList);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _visualManager = new VisualManager(this);

            if (_adminManager.Products.Count > 0)
                _visualManager.SetControlStatus(false, mni_editProduct, mni_deleteProduct);
            else
                _visualManager.SetControlStatus(false, mni_editProduct, mni_deleteProduct);

            _visualManager.TableSetup(dtg_adminTable, _adminManager.Products);
            SetPropertiesPanelsVisibility(VisibilityStatus.HideBoth);
            _visualManager.ComboBoxSetup(cmb_productCategory, Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToArray());
        }

        private void SetupAddProductControls()
        {
            SetPropertiesPanelsVisibility(VisibilityStatus.HideBoth);

            if (pnl_addProduct.Visible)
                return;

            _visualManager.ShowControlsPanel(VisibilityStatus.HideBoth, pnl_addProduct, pnl_editProduct);
            _visualManager.ComboBoxSetup(cmb_productCategory, Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToArray());
        }

        private void mni_AddProduct_Click(object sender, EventArgs e)
        {
            SetupAddProductControls();
        }

        private void mni_foodProduct_Click(object sender, EventArgs e)
        {
            SetPropertiesPanelsVisibility(VisibilityStatus.ShowFoodProperties);
        }

        private void mni_nonFoodProduct_Click(object sender, EventArgs e)
        {
            SetPropertiesPanelsVisibility(VisibilityStatus.ShowNonFoodProperties);
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

            _visualManager.ResetAllInputFields(pnl_addProduct);
            SetPropertiesPanelsVisibility(VisibilityStatus.HideBoth);
            _visualManager.SetControlStatus(false, mni_editProduct, mni_deleteProduct);
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

            _visualManager.ResetAllInputFields(pnl_addProduct);
            SetPropertiesPanelsVisibility(VisibilityStatus.HideBoth);
            _visualManager.SetControlStatus(false, mni_editProduct, mni_deleteProduct);
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
                _visualManager.SetTextInputFeedback(txt_productName);
                MessageBox.Show(
                    "The name field cannot be empty or just whitespaces.",
                    "PRODUCT NAME NOT VALID",
                    MessageBoxButtons.OK
                    );
                return false;
            }

            if (cmb_productCategory.SelectedIndex == 0)
            {
                _visualManager.SetTextInputFeedback(cmb_productCategory);
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

        private void SetPropertiesPanelsVisibility(VisibilityStatus visibility)
        {
            _visualManager.SetPropertiesBoxVisibility(
                visibility,
                new Control[] { lbl_foodProperties, pnl_foodProperties, btn_AddFoodProduct },
                new Control[] { lbl_nonFoodProperties, pnl_nonFoodProperties, btn_addNonFoodProduct }
                );
        }

        private void mni_editProduct_Click(object sender, EventArgs e)
        {
            _visualManager.ShowControlsPanel(VisibilityStatus.HideBoth, pnl_editProduct, pnl_addProduct);
            _visualManager.SetControlAbsoluteLocation(pnl_editProduct, pnl_addProduct.Location);
            _visualManager.ComboBoxSetup(cmb_productEditSelected, _adminManager.Products, "Name", -1);
        }

        private void cmb_productEditSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmb_productEditSelected.SelectedIndex;

            if (selectedIndex == -1)
                return;

            Product selectedProduct = _adminManager.Products[selectedIndex];

            lbl_productBrandImmutable.Text = selectedProduct.Brand;
            lbl_productCategoryImmutable.Text = selectedProduct.Category.ToString();
            lbl_productStockImmutable.Text = selectedProduct.Stock.ToString();
            SetProductPropertyField(selectedProduct);
            nmr_productPriceEdit.Value = (decimal)selectedProduct.Price;
        
            if(selectedProduct.DiscountPercentage > 0)
                nmr_productPercentageEdit.Value = selectedProduct.DiscountPercentage;
        }

        private void SetProductPropertyField(Product product)
        {
            bool isFoodProduct = Utilities.IsFoodProduct(product);
            string labelValue, fieldValue;
            VisibilityStatus visibility;

            if (isFoodProduct)
            {
                FoodProduct convertedProduct = (FoodProduct)product;

                labelValue = "Expiring date:";
                fieldValue = convertedProduct.ExpiringDate.ToString("dd-MM-yyyy");
                visibility = VisibilityStatus.ShowFoodProperties;
                nmr_productWeightEdit.Value = (decimal)convertedProduct.Weight;
            }
            else
            {
                NonFoodProduct convertedProduct = (NonFoodProduct)product;

                labelValue = "Age restriction:";
                fieldValue = convertedProduct.AgeRestriction.ToString();
                visibility = VisibilityStatus.ShowNonFoodProperties;
                chc_productFragileEdit.Checked = convertedProduct.Fragile;
            }

            lbl_dateOrAgeEdit.Text = labelValue;
            lbl_productDateOrAgeImmutable.Text = fieldValue;
            _visualManager.SetPropertiesBoxVisibility(visibility, new Control[] { pnl_foodProductEdit }, new Control[] { pnl_nonFoodProductEdit });
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminManager.SaveProducts();
        }

        private void btn_productEdit_Click(object sender, EventArgs e)
        {
            int selectedItemIndex = cmb_productEditSelected.SelectedIndex;

            if (selectedItemIndex == -1)
                return;

            Product product = _adminManager.Products[selectedItemIndex];

            ProductOptions options = new ProductOptions()
            {
                Name = product.Name,
                Brand = product.Brand,
                Category = product.Category,
                Stock = product.Stock,
                Price = (float)nmr_productPriceEdit.Value,
                DiscountPercentage = (uint)(chc_productDiscountedEdit.Checked 
                ? nmr_productPercentageEdit.Value 
                : product.DiscountPercentage)
            };

            if (Utilities.IsFoodProduct(product))
            {
                FoodProduct productToEdit = (FoodProduct)product;

                FoodProduct? foodProduct = Utilities.CreateProduct(
                    options,
                    (float)nmr_productWeightEdit.Value,
                    DateTime.ParseExact(lbl_productDateOrAgeImmutable.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    );

                _adminManager.EditProduct(productToEdit, foodProduct);
            }
            else
            {
                NonFoodProduct productToEdit = (NonFoodProduct)product;

                NonFoodProduct? foodProduct = Utilities.CreateProduct(
                    options,
                    chc_productDiscountedEdit.Checked,
                    uint.Parse(lbl_productDateOrAgeImmutable.Text)
                    );

                _adminManager.EditProduct(productToEdit, foodProduct);
            }
        }

        private void chc_productDiscountedEdit_CheckedChanged(object sender, EventArgs e)
        {
            bool discountPercentageVisible = true;

            if (!chc_productDiscountedEdit.Checked)
                discountPercentageVisible = false;

            lbl_percentageEdit.Visible = discountPercentageVisible;
            nmr_productPercentageEdit.Visible = discountPercentageVisible;

        }
    }

}