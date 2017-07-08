using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private ShoppingCartContext context;

        public ProductRepository(ShoppingCartContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductByID(int id)
        {
            return context.Products.Find(id);
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
