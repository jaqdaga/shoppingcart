using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    interface ISubcategoryRepository : IDisposable
    {
        IEnumerable<Subcategory> GetSubcategories();
        Subcategory GetSubcategoryByID(int subcategoryId);
        void Save();
    }
}
