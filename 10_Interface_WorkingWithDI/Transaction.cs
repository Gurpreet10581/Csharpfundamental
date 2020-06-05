using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface_WorkingWithDI
{
    public class Transaction
    {
        //below is going to be read only  and private so it is only being used at the time of creation
        private readonly ICurrency _currency;
        public  Transaction(ICurrency currency)//cunstructer
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }
        public DateTimeOffset DateOfTransaction { get; set; }

        public decimal GetTransactionAmount()//made it public because first one was private 
        {
            return _currency.Value;
        }
        public string GetTransactionType() => _currency.Name;// used lamda here since it is a string
    }
}
