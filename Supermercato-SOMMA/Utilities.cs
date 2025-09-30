using Supermercato_SOMMA.Managers;
using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA
{
    public static class Utilities
    {
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

        public static bool IsFoodProduct(Product product)
        {
            int productCategoryIndex = (int)product.Category;

            if (productCategoryIndex > 0 && productCategoryIndex < 4)
                return true;
            else if (productCategoryIndex >= 4 && productCategoryIndex <= 7)
                return false;

            return false;
        }

        public static bool IsFoodProduct(ProductCategory category)
        {
            if ((int)category > 0 && (int)category < 4)
                return true;
            else if ((int)category >= 4 && (int)category <= 7)
                return false;

            return false;
        }

    }
    
}
