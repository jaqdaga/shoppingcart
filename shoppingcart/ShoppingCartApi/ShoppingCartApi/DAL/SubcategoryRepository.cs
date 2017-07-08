using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    public class SubcategoryRepository : ISubcategoryRepository, IDisposable
    {
        private ShoppingCartContext context;

        public SubcategoryRepository(ShoppingCartContext context)
        {
            this.context = context;
        }

        public IEnumerable<Subcategory> GetSubcategories()
        {
            return context.Subcategories.ToList();
        }

        public Subcategory GetSubcategoryByID(int id)
        {
            return context.Subcategories.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
