using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class NonFoodProduct : Product
    {
        private bool _fragile;
        private uint _ageRestriction;

        public NonFoodProduct() : base()
        {

        }

        public NonFoodProduct(ProductOptions options, bool fragile, uint ageRestriction) 
            : base(options)
        {
            Fragile = fragile;
            AgeRestriction = ageRestriction;
        }

        public bool Fragile
        {
            get => _fragile;
            set
            {
                _fragile = value;
            }
        }

        public uint AgeRestriction
        {
            get => _ageRestriction;
            set
            {
                if (value > 17)
                    throw new ArgumentException("The maximum age restriction is 17 years old.");

                _ageRestriction = value;
            }
        }
    }
}
