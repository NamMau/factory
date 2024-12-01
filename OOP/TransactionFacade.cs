using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class TransactionFacade
    {
        private readonly TransactionStorage _transactionStorage;

        public TransactionFacade()
        {
            _transactionStorage = TransactionStorage.Instance; 
        }

        public void SaveTransaction(string transactionType)
        {

            var transaction = TransactionFactory.CreateTransaction(transactionType);

            // Save to Storage
            _transactionStorage.SaveTransaction(transaction);
        }
    }
}
