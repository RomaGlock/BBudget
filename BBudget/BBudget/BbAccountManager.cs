using System;
using System.Collections.Generic;
using System.Text;

namespace BBudget
{
    class BbAccountManager
    {
        public event Action<BbAccount, BbAccount, decimal> TransactionOccured;

        public List<BbTransaction>  Transactions;
        public List<BbAccount>      Accounts;

        public BbAccountManager(params BbAccount[] accounts)
        {
            Transactions = new List<BbTransaction>();
            Accounts = new List<BbAccount>(accounts);

            foreach (var account in Accounts)
            {
                TransactionOccured += account.TransactionOccuredHandler;
            }
        }

        public void AddTransaction(BbTransaction tr)
        {
            Transactions.Add(tr);
            TransactionOccured?.Invoke(tr.Src, tr.Dst, tr.Value);
        }

        public void AddTransaction(BbAccount src, BbAccount dst, decimal value)
        {
            Transactions.Add(new BbTransaction(src, dst, value));
            TransactionOccured?.Invoke(src, dst, value);
        }
    }
}
