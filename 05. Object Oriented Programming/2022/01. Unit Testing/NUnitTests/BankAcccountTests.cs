using Demo;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void TestInit()
        {
            this.account = new BankAccount();
        }

        [Test]
        public void ZeroTest()
        {
            Assert.AreEqual(0m, account.Amount);
        }

        [Test]
        public void SetTest()
        {
            account.Amount = 1000m;
            Assert.AreEqual(1000m, account.Amount);
        }
        [Test]
        public void DepositTest()
        {
            account.Deposit(50);
            Assert.IsTrue(account.Amount == 50);
        }

        [Test]
        public void ExceptionTest()
        {
            var ex = Assert.Throws<Exception>(() => account.Deposit(-100));
            Assert.That(ex.Message, Is.EqualTo("Must be positive"));
        }
    }
}