using Supermercato_SOMMA.Models;
using Supermercato_SOMMA.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA
{
    public class AdminManager : IManager
    {
        private readonly BindingList<Product> _products;

        public AdminManager()
        {
            _products = new BindingList<Product>();
        }

        public void AddProduct(Product productToAdd)
        {

        }
    }
}
