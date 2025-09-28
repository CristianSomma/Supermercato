using Supermercato_SOMMA.Models;
using Supermercato_SOMMA.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Managers
{
    public class AdminManager
    {
        private readonly BindingList<Product> _products;

        public AdminManager()
        {
            _products = new BindingList<Product>();
        }

        public BindingList<Product> Products
        {
            get => _products;
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
            if (productToEdit.GetType() != newProductVersion.GetType())
                return false;

            int indexOfProductToEdit = _products.IndexOf(productToEdit);

            if (indexOfProductToEdit == -1)
                return false;

            // FIXME: SE PRODOTTO E' MOLTO SIMILE NON CAMBIARE CODICE

            _products[indexOfProductToEdit] = newProductVersion;
            return true;
        }

        public bool RemoveProduct(Product productToRemove)
        {
            return _products.Remove(productToRemove);
        }

    }
}
