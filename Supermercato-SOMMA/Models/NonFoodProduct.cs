using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class NonFoodProduct : Product
    {
        private bool _fragile;
        private uint _ageRestriction;

        public NonFoodProduct(ProductOptions options, bool fragile, uint ageRestriction) 
            : base(options)
        {

        }

        public bool Fragile
        {
            get => _fragile;
            private set
            {
                _fragile = value;
            }
        }

        public uint AgeRestriction
        {
            get => _ageRestriction;
            private set
            {
                if (value > 17)
                    throw new ArgumentException("The maximum age restriction is 17 years old.");

                _ageRestriction = value;
            }
        }
    }
}
