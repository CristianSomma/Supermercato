using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class CartItem : Product
    {
        private uint _quantity;

        public CartItem(ProductOptions options, uint quantity = 0)
            : base(options)
        {
            Quantity = quantity;
        }

        public uint Quantity
        {
            get => _quantity;
            private set
            {
                if (value > 99)
                    throw new ArgumentException("The product's quantity cannot be more than 99.");

                _quantity = value;
            }
        }
    }
}
