using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.DAL
{
    interface IRecordRepository : IDisposable
    {
        IEnumerable<Record> GetRecords();
        Record GetRecordByID(int recordId);
        void Save();
    }
}
