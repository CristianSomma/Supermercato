using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Managers
{
    public class VisualManager
    {
        private Form _form;

        public VisualManager(Form form)
        {
            _form = form;
        }

        public void SetControlAbsoluteLocation(Control control, Point coordinates)
        {
            control.Location = coordinates;
        }

        public void SetControlAbsoluteLocation(Control control, int x, int y)
        {
            control.Location = new Point(x, y);
        }

        public void SetControlStatus(bool setToDisabled, params Control[] controls)
        {
            foreach (Control control in controls)
                control.Enabled = !setToDisabled;
        }

        public void SetControlStatus(bool setToDisabled, params ToolStripMenuItem[] menuItems)
        {
            foreach (ToolStripMenuItem item in menuItems)
                item.Enabled = !setToDisabled;
        }

        
        public void ResetAllInputFields(Control parent)
        {
            foreach(Control control in parent.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = "";
                    SetTextInputFeedback(textBox, false);
                }

                if(control is NumericUpDown nmr)
                    nmr.Value = nmr.Minimum;

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

        public void SetPropertiesBoxVisibility(VisibilityStatus visibility, Control[] foodPropertiesControls, Control[] nonFoodPropertiesControls)
        {
            (bool foodProductVisibility, bool nonFoodProductVisibility) visibilities = GetVisibilityStatus(visibility);

            foreach (Control control in foodPropertiesControls)
            {
                control.Visible = visibilities.foodProductVisibility;

                if (control is Panel panel && visibilities.foodProductVisibility)
                    panel.BringToFront();
            }

            foreach (Control control in nonFoodPropertiesControls)
            {
                control.Visible = visibilities.nonFoodProductVisibility;

                if (control is Panel panel && visibilities.nonFoodProductVisibility)
                {
                    panel.BringToFront();
                    SetControlAbsoluteLocation(panel, 676, 122);
                }
            }
        }

        public void ShowControlsPanel(VisibilityStatus visibility, Panel panelToShow, params Panel[] panelsToHide)
        {
            foreach (Panel panelToHide in panelsToHide)
            {
                panelToHide.Visible = false;
            }

            panelToShow.Visible = true;

            if (panelToShow.HasChildren)
                HideProductsPropertiesPanels(panelToShow, visibility);
        }

        public void TableSetup<T>(DataGridView table, BindingList<T> list) where T : class
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

        public void SetTextInputFeedback(Control inputComponent, bool errorStatus = true)
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

        public void ComboBoxSetup<T>(ComboBox comboBox, BindingList<T> list, string displayField, int defaultIndex = 0)
        {
            comboBox.DataSource = list;
            comboBox.SelectedIndex = defaultIndex;

            if (typeof(T).GetProperty(displayField) != null)
                comboBox.DisplayMember = displayField;
        }

        public void ComboBoxSetup<TEnum>(ComboBox comboBox, TEnum[] list, int defaultIndex = 0) where TEnum : Enum
        {
            comboBox.DataSource = list;
            comboBox.DisplayMember = "ToString";
            comboBox.SelectedIndex = 0;
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

            foreach (char character in stringToSplit)
            {
                if (character > 'A' && character < 'Z')
                    result += $" {character}";
                else
                    result += character;
            }

            return result;
        }

        private void HideProductsPropertiesPanels(Control parent, VisibilityStatus visibility)
        {
            (bool foodProductVisibility, bool nonFoodProductVisibility) visibilities = GetVisibilityStatus(visibility);

            foreach (Control control in parent.Controls)
            {
                if (control is not Panel)
                    continue;

                string controlName = control.Name.ToLower();

                if (controlName.Contains("pnl_foodproduct"))
                    control.Visible = visibilities.foodProductVisibility;
                else if (controlName.Contains("pnl_nonfoodproduct"))
                    control.Visible = visibilities.nonFoodProductVisibility;
            }
        }

        private (bool foodProductVisibility, bool nonFoodProductVisibility) GetVisibilityStatus(VisibilityStatus visibility)
        {
            bool foodProduct = false;
            bool nonFoodProduct = false;

            switch (visibility)
            {
                case VisibilityStatus.HideBoth:
                    break;

                case VisibilityStatus.ShowFoodProperties:
                    foodProduct = true;
                    break;

                case VisibilityStatus.ShowNonFoodProperties:
                    nonFoodProduct = true;
                    break;
            }

            return (foodProduct, nonFoodProduct);
        }
    }

    public enum VisibilityStatus
    {
        HideBoth,
        ShowFoodProperties,
        ShowNonFoodProperties
    }
}

