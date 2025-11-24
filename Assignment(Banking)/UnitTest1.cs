using static Assignment_Banking_.Assignment;

namespace Assignment_Banking_
{
    //Exercise-1
    public class Tests
    {
        [Test]
        public void OpeningBalance_ShouldBeStoredCorrectly()
        {
            BankAccount acc = new BankAccount(500);
            Assert.That(acc.Balance, Is.EqualTo(500));
        }        
    }
    //Exercise-2
    public class Deposit
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance()
        {
            BankAccount acc = new BankAccount(10000);
            acc.Deposit(2000);
            Assert.That(acc.Balance, Is.EqualTo(12000));
        }
    }
    //Exercise-3
    public class Withdraw
    {
        [Test]
        public void Withdraw_ShouldDecreaseBalance()
        {
            BankAccount acc = new BankAccount(500);

            acc.Withdraw(300);

            Assert.That(acc.Balance, Is.EqualTo(200));
        }

        [Test]
        public void Withdraw_MoreThanBalance_ShouldThrow()
        {
            BankAccount acc = new BankAccount(500);

            Assert.Throws<InvalidOperationException>(() => acc.Withdraw(600));
        }
    }
    //Exercise-4
    public class DepositTestCase
    {
        [TestCase(100, 50, 150)]
        [TestCase(0, 100, 100)]
        [TestCase(500, 0, 500)]
        public void Deposit_TestCases(decimal opening, decimal deposit, decimal expected)
        {
            BankAccount acc = new BankAccount(opening);

            if (deposit > 0)
                acc.Deposit(deposit);

            Assert.That(acc.Balance, Is.EqualTo(expected));
        }
    }
    //Exercise-5
    public class History
    {
        [Test]
        public void HistoryCount_ShouldBeTwo()
        {
            BankAccount acc = new BankAccount(1000);
            acc.Deposit(500);
            acc.Deposit(250);
            Assert.That(acc.History.Count, Is.EqualTo(2));
        }
    }
    //Exercise-6
    public class WithdrawTestCaseSource
    {
        public static IEnumerable<object[]> WithdrawCases()
        {
            yield return new object[] { 1000m, 200m, 800m };
            yield return new object[] { 500m, 100m, 400m };
            yield return new object[] { 250m, 50m, 200m };
        }
        [Test]
        [TestCaseSource(nameof(WithdrawCases))]
        public void Withdraw_ShouldMatchExpectedBalance(decimal opening, decimal amount, decimal expected)
        {
            BankAccount acc = new BankAccount(opening);

            acc.Withdraw(amount);

            Assert.That(acc.Balance, Is.EqualTo(expected));
        }
    }
    //Exercise-7
    public class NegativeDeposit
    {
        [Test]
        public void Deposit_NegativeAmount_ShouldThrow()
        {
            BankAccount acc = new BankAccount(500);

            var ex = Assert.Throws<ArgumentException>(() => acc.Deposit(-50));

            Assert.That(ex.Message, Does.Contain("positive"));
        }
    }
    //Exercise-8
    public class WithdrawDoesNotChangeBalance
    {
        [Test]
        public void Withdraw_MoreThanBalance_ShouldNotChangeBalance()
        {
            BankAccount acc = new BankAccount(500);
            Assert.Throws<InvalidOperationException>(() => acc.Withdraw(900));

            Assert.That(acc.Balance, Is.EqualTo(500));
        }
    }
    //Exercise-9
    public class Interest
    {
        [Test]
        public void ApplyInterest_ShouldIncreaseBalanceCorrectly()
        {
            BankAccount acc = new BankAccount(1000);

            acc.ApplyInterest(0.05m);

            Assert.That(acc.Balance, Is.EqualTo(1050));
        }
    }
}

