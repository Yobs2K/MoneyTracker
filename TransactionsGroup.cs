using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    public class TransactionsGroup
    {
        private List<Transaction> transactions = new List<Transaction>();
        private string groupName;

        public TransactionsGroup(string Name)
        {
            groupName = Name;
        }

        public void addTransaction (Transaction trans)
        {
            transactions.Add(trans);
        }

        public void deleteTransaction(int index)
        {
            transactions.RemoveAt(index);
        }

        public string getName()
        {
            return groupName;
        }

        public List<Transaction> getList()
        {
            return transactions;
        }

        public void setName(string Name)
        {
            groupName = Name;
        }

        public double getSumm ()
        {
            double summ = 0;
            foreach (Transaction trans in transactions)
            {
                summ += trans.getSumm();
            }
            return summ;
        }
    }
}
