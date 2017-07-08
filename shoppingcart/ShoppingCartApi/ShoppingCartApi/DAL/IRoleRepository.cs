using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    interface IRoleRepository : IDisposable
    {
        IEnumerable<Role> GetRoles();
        Role GetRoleByID(int roleId);
        void Save();
    }
}
