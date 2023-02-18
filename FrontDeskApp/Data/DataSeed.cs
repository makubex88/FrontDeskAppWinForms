using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskApp.Model
{
    public class DataSeed
    {
        public List<StorageTransactionType> GetStorageTransactionTypes() 
        { 

            return new List<StorageTransactionType>
            {
                new StorageTransactionType
                {
                    Id= 1,
                    Name = "Stored"
                },
                new StorageTransactionType
                {
                    Id= 1,
                    Name = "Retrieved"
                },
            };
        }

        public List<Storage> GetListOfStorage()
        {
            return new List<Storage>
            {
                new Storage
                {
                    Id= 1,
                    StorageName = "Location One",
                    TotalOfSmallStorage= 46,
                    TotalOfMediumStorage = 14,
                    TotalOfLargeStorage = 12,
                }
            };
        }


    }
}
