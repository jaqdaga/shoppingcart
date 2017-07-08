using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    public class RecordRepository : IRecordRepository, IDisposable
    {
        private ShoppingCartContext context;

        public RecordRepository(ShoppingCartContext context)
        {
            this.context = context;
        }

        public IEnumerable<Record> GetRecords()
        {
            return context.Records.ToList();
        }

        public Record GetRecordByID(int id)
        {
            return context.Records.Find(id);
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
