using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Models.Interfaces
{
    public interface IManager
    {
        public void AddProduct(Product product);
        public void EditProduct(Product product);
        public void RemoveProduct(Product product);
    }
}
