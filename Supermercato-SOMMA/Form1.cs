using Supermercato_SOMMA.Managers;
using Supermercato_SOMMA.Models;
using System.CodeDom;

namespace Supermercato_SOMMA
{
    public partial class AdminForm : Form
    {
        private AdminManager _adminManager;

        public AdminForm()
        {
            InitializeComponent();
            _adminManager = new AdminManager();
            TableSetup();
            SetPropertiesBoxVisibility(VisibilityStatus.HideBoth);
        }

        private void TableSetup()
        {
            dtg_adminTable.DataSource = _adminManager.Products;
            dtg_adminTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i<dtg_adminTable.Columns.Count; i++)
            {
                DataGridViewColumn currentColumn = dtg_adminTable.Columns[i];

                SetColumnWidthAndFormat(currentColumn);
                currentColumn.HeaderText = SplitOnCapitalLetters(currentColumn.HeaderText);
            }

        }

        private void SetColumnWidthAndFormat(DataGridViewColumn column)
        {
            Type columnDataType = column.ValueType;
            float percentageToOccupy;

            if (columnDataType == typeof(string))
                percentageToOccupy = 40;
            else if (columnDataType == typeof(float))
            {
                percentageToOccupy = 20;

                column.DefaultCellStyle.Format = column.HeaderText.ToUpper() == "PRICE"
                    ? "C2"
                    : "F2";
            }
            else if (columnDataType == typeof(ProductCategory))
                percentageToOccupy = 30;
            else if (columnDataType == typeof(uint))
                percentageToOccupy = 25;
            else if (columnDataType == typeof(DateTime))
                percentageToOccupy = 40;
            else
                percentageToOccupy = 5;

                column.FillWeight = percentageToOccupy;
        }

        private string SplitOnCapitalLetters(string stringToSplit)
        {
            string result = "";

            foreach(char character in stringToSplit)
            {
                if (character > 'A' && character < 'Z')
                    result += $" {character}";
                else
                    result += character;
            }

            return result;
        }

        private void SetPropertiesBoxVisibility(VisibilityStatus visibility = VisibilityStatus.HideBoth)
        {
            bool foodPropertiesVisible = false;
            bool nonFoodPropertiesVisible = false;

            switch (visibility)
            {
                case VisibilityStatus.HideBoth:
                    break;
                case VisibilityStatus.ShowFoodProperties:
                    foodPropertiesVisible = true;
                    break;
                case VisibilityStatus.ShowNonFoodProperties:
                    nonFoodPropertiesVisible = true;
                    break;
            }

            lbl_foodProperties.Visible = foodPropertiesVisible;
            pnl_foodProperties.Visible = foodPropertiesVisible;
            lbl_nonFoodProperties.Visible = nonFoodPropertiesVisible;
            pnl_nonFoodProperties.Visible = nonFoodPropertiesVisible;

            pnl_foodProperties.BringToFront();
            pnl_nonFoodProperties.BringToFront();
        }
        
        private void mni_AddProduct_Click(object sender, EventArgs e)
        {
            SetPropertiesBoxVisibility(VisibilityStatus.HideBoth);
        }

        private void mni_foodProduct_Click(object sender, EventArgs e)
        {
            SetPropertiesBoxVisibility(VisibilityStatus.ShowFoodProperties);
        }

        private void mni_nonFoodProduct_Click(object sender, EventArgs e)
        {
            SetPropertiesBoxVisibility(VisibilityStatus.ShowNonFoodProperties);
        }

    }

    public enum VisibilityStatus
    {
        HideBoth,
        ShowFoodProperties,
        ShowNonFoodProperties
    }
}