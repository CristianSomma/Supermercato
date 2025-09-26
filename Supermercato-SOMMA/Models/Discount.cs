using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models
{
    public class Discount
    {
        private bool _isDiscounted;
        private uint? _percentage;

        public Discount()
        {
            IsDiscounted = false;
        }

        public Discount(bool isDiscounted, uint percentage)
        {
            IsDiscounted = isDiscounted;
            Percentage = percentage;
        }

        public bool IsDiscounted
        {
            get => _isDiscounted;
            private set
            {
                if (!value)
                    _percentage = null;

                _isDiscounted = value;
            }
        }

        public uint? Percentage
        {
            get => _percentage;
            private set
            {
                if (_isDiscounted)
                {
                
                    if (value == 0 || value > 99)
                        throw new ArgumentException("The product's discount has to be more than 0% and less than 100%.");
                    _percentage = value;
                
                }else
                    _percentage = null;
            }
        }
    }
}
