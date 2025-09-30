using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Managers
{
    public class ClientManager
    {
        private readonly BindingList<(Product Product, uint Quantity)> _orderedProducts;

        public ClientManager()
        {
            _orderedProducts = new BindingList<(Product Product, uint Quantity)>();
        }

        public BindingList<(Product Product, uint Quantity)> OrderedProducts
        {
            get => _orderedProducts;
        }

        public float AddProduct(Product orderedProduct, uint quantity, float totalPrice)
        {
            if (quantity <= 0 || quantity > 99)
                return 0;

            _orderedProducts.Add((orderedProduct, quantity));
            return totalPrice + CalculateOrderPrice(orderedProduct, quantity);
        }

        private float CalculateOrderPrice(Product orderedProduct, uint quantity)
        {
            float totalPrice = (float)(orderedProduct.Price * quantity);
            
            if (orderedProduct.DiscountPercentage > 0)
            {
                totalPrice -= (totalPrice * orderedProduct.DiscountPercentage / 100);
                return totalPrice;
            }
            else
                return totalPrice;

        }
    }
}
