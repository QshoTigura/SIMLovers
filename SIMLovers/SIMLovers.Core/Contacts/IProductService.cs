using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIMLovers.Infrastructure.Data.Domain;

namespace SIMLovers.Core.Contacts
{
    public interface IProductService
    {
        bool Create(string name, int brandId, int categoryId, string description, int torque, string style, string picture, int quantity, decimal price, decimal discount);
        bool Update(int productId, string name, int brandId, int categoryId, string description, int torque, string style, string picture, int quantity, decimal price, decimal discount);

        List<Product> GetProducts();

        Product GetProductById(int productId);
        bool RemoveById(int productId);
        List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandName);
    }
}
