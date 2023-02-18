namespace FrontDeskAppAPI.Model
{
    public class StorageTransaction
    {
        public int Id { get; set; }
        public Storage Storage { get; set; }
        public Customer Customer { get; set; }
        public StorageTransactionType TransactionType { get; set; }
    }
}
