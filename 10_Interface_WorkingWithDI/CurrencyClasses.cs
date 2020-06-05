using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface_WorkingWithDI// Second file- currency exmaple 
{
    public class Penny : ICurrency // changed to Penny and added :ICurrency
    {
        public string Name
        {
            get
            {
                return "Penny"; // hardcoding it so no one can change it
            }
        }
        public decimal Value
        {
            get { return 0.01m; }//hardcoding it so no one can change it 
        }
    }
    public class Dime: ICurrency
    {
        public string Name
        {
            get { return "Dime"; }
        }
        public decimal Value
        {
            get { return 0.10m; }//used m because it is a decimal value
        }
    }
    public class Dollar: ICurrency
    {
        public string Name
        {
            get { return "Dollar"; }
        }
        public decimal Value
        {
            get { return 1.0m; }
        }
    }
    public class ElectronicPayment: ICurrency
    {
        public string Name
        {
            get { return "Electronic Payment"; }
        }
        public decimal Value { get; }// since the value for electronic payment can change so we can not set a value with return

        public ElectronicPayment(decimal value)// did below so no one else can change it
        {
            Value = value;
        }
    }
}
