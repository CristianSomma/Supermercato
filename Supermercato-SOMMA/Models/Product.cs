using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public abstract class Product
    {
        private string _name, _code;
        private string? _brand;
        private ProductCategory _category;
        private float _price;
        private float? _weight;
        private DateTime _expiringDate;
        private readonly Discount _discount;
        private uint _avaiableQuantity;

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
                int categoriesCount = Enum.GetValues(typeof(ProductCategory)).Length;

                if (value == ProductCategory.SelezionaCategoria)
                    throw new ArgumentException("The category of the product cannot be the standard value.");
                else if ((int)value > categoriesCount)
                    throw new ArgumentException("The category enum element must exist.");

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
            }
        }

        public Discount Discount
        {
            get => _discount;
        }

        public uint AvaiableQuantity
        {
            get => _avaiableQuantity;
            private set
            {
                _avaiableQuantity = value;
            }
        }

        public string Code
        {
            get => _code;
            private set
            {
                throw new NotImplementedException("Implement the code property of Product.cs");
            }
        }
    }

    public enum ProductCategory
    {
        SelezionaCategoria,
        AlimentariFreschi,
        AlimentariConfezionati,
        Surgelati,
        PerLaCasa,
        CuraPersonale,
        AnimaliDomestici,
        Altro
    }
}
