using Supermercato_SOMMA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Supermercato_SOMMA.Managers
{
    public class FileManager
    {
        private string _path;

        public FileManager(string path)
        {
            Path = path;
        }

        public string Path
        {
            get => _path;
            private set
            {
                if (!File.Exists(value))
                    throw new FileNotFoundException($"The file at {value} wasn't found.");

                _path = value;
            }
        }

        public void SerializeProduct(Product product)
        {
            using (FileStream fileStream = new FileStream(_path, FileMode.Append, FileAccess.Write, FileShare.Read))
            {
                Serialize(fileStream, product);
            }
        }

        private void Serialize(FileStream stream, Product product)
        {
            using (var sw = new StreamWriter(stream, leaveOpen: true))
            {
                string json = Utilities.IsFoodProduct(product)
                    ? JsonSerializer.Serialize((FoodProduct)product)
                    : JsonSerializer.Serialize((NonFoodProduct)product);

                sw.WriteLine(json);
            }
        }

        public void SerializeAllProducts (BindingList<Product> products)
        {
            using (FileStream fileStream = new FileStream(_path, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                foreach(Product product in products)
                {
                    Serialize(fileStream, product);
                }
            }
        }

        public void DeserializeProducts(BindingList<Product> destinationList)
        {
            using (var sr = new StreamReader(_path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var doc = JsonDocument.Parse(line);
                    ProductCategory category = (ProductCategory)doc.RootElement.GetProperty("Category").GetInt32();

                    if (Utilities.IsFoodProduct(category))
                        destinationList.Add(JsonSerializer.Deserialize<FoodProduct>(line));
                    else
                        destinationList.Add(JsonSerializer.Deserialize<NonFoodProduct>(line));
                }
            }

        }
    }
}
