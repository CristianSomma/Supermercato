using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public abstract class Product
    {
        private string _name, _code;
        private string? _brand;
        private ProductCategory _category;
        private float _price;
        private uint _discountPercentage;
        private uint _stock;

        protected Product()
        {

        }

        protected Product(ProductOptions options)
        {
            Name = options.Name;
            Brand = options.Brand;
            Category = options.Category;
            Price = options.Price;
            DiscountPercentage = options.DiscountPercentage;
            Stock = options.Stock;
            _code = CreateCode();
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("The product name cannot be null or just white spaces.");

                _name = value.ToUpper();
            }
        }

        public string? Brand
        {
            get => _brand;
            set
            {
                _brand = value?.ToUpper();
            }
        }

        public ProductCategory Category
        {
            get => _category;
            set
            {
                if (value == ProductCategory.SelectCategory)
                    throw new ArgumentException("The standard category isn't valid.");

                _category = value;
            }
        }

        public float Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The product's price must be a positive value.");

                _price = value;
            }
        }

        public uint DiscountPercentage
        {
            get => _discountPercentage;
            set
            {
                if (value > 100)
                    throw new ArgumentException("The discount percentage must be a positive value and between 0 and 100.");

                _discountPercentage = value;
            }
        }

        public uint Stock
        {
            get => _stock;
            set
            {
                _stock = value;
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                _code = value;
            }
        }

        private string CreateCode()
        {
            Random random = new Random(Environment.TickCount);
            
            string code = $"0{(int)_category}-";

            for(int i = code.Length; i<10; i++)
            {
                code += random.Next(0, 10);
            }

            return code;
        }
    }

    public enum ProductCategory
    {
        SelectCategory,
        FreshFood,
        PackagedFood,
        FrozenFood,
        Household,
        PersonalCare,
        PetCare,
        Other
    }
}
