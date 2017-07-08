using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    public class RoleRepository : IRoleRepository, IDisposable
    {
        private ShoppingCartContext context;

        public RoleRepository(ShoppingCartContext context)
        {
            this.context = context;
        }

        public IEnumerable<Role> GetRoles()
        {
            return context.Roles.ToList();
        }

        public Role GetRoleByID(int id)
        {
            return context.Roles.Find(id);
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
