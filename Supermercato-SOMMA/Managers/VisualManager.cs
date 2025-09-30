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

        private void HideProductsPropertiesPanels(Control parent, VisibilityStatus visibility)
        {
            (bool foodProductVisibility, bool nonFoodProductVisibily) visibilities = GetVisibilityStatus(visibility);

            foreach (Control control in parent.Controls)
            {
                if (control is not Panel)
                    continue;

                string controlName = control.Name.ToLower();

                if (controlName.Contains("pnl_foodproduct"))
                    control.Visible = visibilities.foodProductVisibility;
                else if (controlName.Contains("pnl_nonfoodproduct"))
                    control.Visible = visibilities.nonFoodProductVisibily;
            }
        }

        private (bool foodProductVisibility, bool nonFoodProductVisibily) GetVisibilityStatus(VisibilityStatus visibility)
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
}

