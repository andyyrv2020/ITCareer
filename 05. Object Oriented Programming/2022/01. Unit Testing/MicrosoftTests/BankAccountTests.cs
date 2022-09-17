using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrosoftTests
{
    [TestClass]
    public class BankAccountTests
    {
        private BankAccount account = new BankAccount();

        [TestMethod]
        public void ZeroTest()
        {
            Assert.AreEqual(0m, account.Amount);
        }

        [TestMethod]
        public void SetTest()
        {
            account.Amount = 1000m;
            Assert.AreEqual(1000m, account.Amount);
        }

        [TestMethod]
        public void DepositTest()
        {
            account.Deposit(50);
            Assert.IsTrue(account.Amount == 50);
        }

        [TestMethod]
        public void ExceptionTest()
        {
            var ex = Assert.ThrowsException<Exception>(() => account.Deposit(-100));
            Assert.AreEqual(ex.Message, "Must be positive");
        }

    }
}