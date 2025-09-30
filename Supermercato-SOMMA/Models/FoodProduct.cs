using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class FoodProduct : Product
    {
        private float _weight;
        private DateTime _expiringDate;

        public FoodProduct(ProductOptions options, float weight, DateTime expiringDate) 
            : base(options)
        {
            Weight = weight;
            ExpiringDate = expiringDate;
        }

        public float Weight
        {
            get => _weight;
            private set
            {
                if (value <= 0 || value > 99)
                    throw new ArgumentException("The product's weight must be positive and less than 100kg.");
             
                _weight = value;
            }
        }

        public DateTime ExpiringDate
        {
            get => _expiringDate;
            private set
            {
                DateTime minimumDate = new DateTime(2020, 1, 1);

                if (value < minimumDate)
                    throw new ArgumentOutOfRangeException($"The expiring date must be after {minimumDate.ToString()}");

                _expiringDate = value;
            }
        }
    }
}
