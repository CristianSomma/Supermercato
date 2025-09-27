using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class Product
    {
        private string _name, _code;
        private string? _brand;
        private ProductCategory _category;
        private float _price;
        private float? _weight;
        private DateTime _expiringDate;
        private uint _discountPercentage;
        private uint _availableQuantity;

        public Product(
            string name,
            ProductCategory category,
            float price,
            DateTime expiringDate,
            uint availableQuantity,
            string? brand = null,
            float? weight = null,
            uint discountPercentage = 0
            )
        {
            Name = name;
            Brand = brand;
            Category = category;
            Price = price;
            Weight = weight;
            ExpiringDate = expiringDate;
            DiscountPercentage = discountPercentage;
            AvailableQuantity = availableQuantity;
            _code = CreateCode();
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("The product name cannot be null or just white spaces.");

                _name = value.ToUpper();
            }
        }

        public string? Brand
        {
            get => _brand;
            private set
            {
                _brand = value?.ToUpper();
            }
        }

        public ProductCategory Category
        {
            get => _category;
            private set
            {
                if (value == ProductCategory.SelezionaCategoria)
                    throw new ArgumentException("The standard category isn't valid.");

                _category = value;
            }
        }

        public float Price
        {
            get => _price;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("The product's price must be a positive value.");

                _price = value;
            }
        }

        public float? Weight
        {
            get => _weight;
            private set
            {
                if (value is null)
                    _weight = value;
                else if (value <= 0 || value > 99)
                    throw new ArgumentException("The product's weight must be positive and less than 100kg.");
                else
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

        public uint DiscountPercentage
        {
            get => _discountPercentage;
            private set
            {
                if (value > 100)
                    throw new ArgumentException("The discount percentage must be a positive value and between 0 and 100.");

                _discountPercentage = value;
            }
        }

        public uint AvailableQuantity
        {
            get => _availableQuantity;
            private set
            {
                _availableQuantity = value;
            }
        }

        public string Code
        {
            get => _code;
        }

        private string CreateCode()
        {
            Random random = new Random(Environment.TickCount);
            
            string code = $"{(int)_category}-";

            for(int i = code.Length; i<10; i++)
            {
                code += random.Next(0, 10);
            }

            return code;
        }
    }

    public enum ProductCategory
    {
        FreshFood,
        PackagedFood,
        FrozenFood,
        Household,
        PersonalCare,
        PetCare,
        Other
    }
}
