using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskApp.Model
{
    public class StorageTransaction
    {
        public int Id { get; set; }
        public Storage Storage { get; set; }
        public Customer Customer { get; set; }
        public string LoadSize { get; set; }
        public int Quantity { get; set; }
        public StorageTransactionType TransactionType { get; set; }
    }
}
