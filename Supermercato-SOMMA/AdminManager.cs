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
    public class AdminManager
    {
        private readonly BindingList<Product> _products;

        public AdminManager()
        {
            _products = new BindingList<Product>();
        }

        public bool AddProduct(Product productToAdd)
        {
            if (_products.Contains(productToAdd))
                return false;

            _products.Add(productToAdd);
            return true;
        }

        public bool EditProduct(Product productToEdit, Product newProductVersion)
        {
            int indexOfProductToEdit = _products.IndexOf(productToEdit);

            if (indexOfProductToEdit == -1)
                return false;

            _products[indexOfProductToEdit] = newProductVersion;
            return true;
        }

        public bool RemoveProduct(Product productToRemove)
        {
            return _products.Remove(productToRemove);
        }
    }
}
