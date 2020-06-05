using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interface_WorkingWithDI
{
    [TestClass]
    public class TransactionTest
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} toards you debt");
        }
        [TestInitialize]///mannually added it 
        public void Arrange()
        {
            _debt = 9000.12m;//used this # as an example
        }
        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());//since there is no  parameter or value in the () it will be considered as $1
            PayDebt(new ElectronicPayment(4000.32m));
            decimal expectedDebt = 9000.12m - 4001.32m;//4001.32m because it was dollar + electronicpayment
            Assert.AreEqual(expectedDebt, _debt);//here we making sure that they are equal 
        }
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var epayment = new ElectronicPayment(1.50m);
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(epayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual(1.50m, secondTransaction.GetTransactionAmount());
        }
    }

}
