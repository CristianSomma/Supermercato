using Supermercato_SOMMA.Managers;
using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA
{
    public static class Utilities
    {
        public static void TableSetup<T>(DataGridView table, BindingList<T> list) where T : class
        {
            table.DataSource = list;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                DataGridViewColumn currentColumn = table.Columns[i];

                SetColumnWidthAndFormat(currentColumn);
                currentColumn.HeaderText = SplitOnCapitalLetters(currentColumn.HeaderText);
            }

        }

        private static void SetColumnWidthAndFormat(DataGridViewColumn column)
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

        private static string SplitOnCapitalLetters(string stringToSplit)
        {
            string result = "";

            foreach (char character in stringToSplit)
            {
                if (character > 'A' && character < 'Z')
                    result += $" {character}";
                else
                    result += character;
            }

            return result;
        }

        public static void SetPropertiesBoxVisibility(VisibilityStatus visibility, Control[] foodPropertiesControls, Control[] nonFoodPropertiesControls)
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

            foreach(Control control in foodPropertiesControls)
            {
                control.Visible = foodPropertiesVisible;

                if (control is Panel panel && foodPropertiesVisible)
                    panel.BringToFront();
            }

            foreach (Control control in nonFoodPropertiesControls)
            {
                control.Visible = nonFoodPropertiesVisible;

                if (control is Panel panel && nonFoodPropertiesVisible)
                {
                    panel.BringToFront();
                    panel.Location = new Point(676, 122);
                }
            }
        }

        public static void SetTextInputFeedback(Control inputComponent, bool errorStatus = true)
        {
            Color backColor = Color.Red;
            Color fontColor = Color.White;

            if (!errorStatus)
            {
                backColor = Color.White;
                fontColor = Color.Black;
            }

            inputComponent.BackColor = backColor;
            inputComponent.ForeColor = fontColor;
        }

        
        public static void ComboBoxSetup<T>(ComboBox comboBox, BindingList<T> list, int defaultIndex = 0)
        {
            comboBox.DataSource = list;
            comboBox.SelectedIndex = 0;
        }

        public static void ComboBoxSetup<TEnum>(ComboBox comboBox, TEnum[] list, int defaultIndex = 0) where TEnum : Enum
        {
            comboBox.DataSource = list;
            comboBox.DisplayMember = "ToString";
            comboBox.SelectedIndex = 0;
        }

        public static void ProductCategoryCombobox(bool isFoodProductSelected)
        {
            Array allCategories = Enum.GetValues(typeof(ProductCategory));
            (int firstIndex, int lastIndex) indexes;

            if (isFoodProductSelected)
                indexes = (1, 4);
            else
                indexes = (4, 8);

            Array filteredCategories = new Array[indexes.lastIndex - indexes.firstIndex];

            for (int i = indexes.firstIndex; i<indexes.lastIndex; i++)
            {
            }
        }

        public static FoodProduct? CreateProduct(ProductOptions options, float weight, DateTime expiringDate)
        {
            FoodProduct product;

            try
            {
                product = new FoodProduct(options, weight, expiringDate);

                return product;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return null;
            }
        }

        public static NonFoodProduct? CreateProduct(ProductOptions options, bool fragile, uint ageRestriction)
        {
            NonFoodProduct product;

            try
            {
                product = new NonFoodProduct(options, fragile, ageRestriction);

                return product;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return null;
            }
        }

        public static void ResetAllInputFields(Control parent)
        {
            foreach(Control control in parent.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = "";
                    SetTextInputFeedback(textBox, false);
                }

                if(control is NumericUpDown nmr)
                {
                    nmr.Value = nmr.Minimum;
                    SetTextInputFeedback(nmr, false);
                }

                if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = 0;

                if (control is CheckBox checkBox)
                    checkBox.Checked = false;

                if (control is DateTimePicker dateTimePicker)
                    dateTimePicker.Value = DateTime.Today;

                if (control.HasChildren)
                    ResetAllInputFields(control);
            }
        }
    }
    public enum VisibilityStatus
    {
        HideBoth,
        ShowFoodProperties,
        ShowNonFoodProperties
    }
}
