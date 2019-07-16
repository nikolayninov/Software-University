using System;

namespace Skeleton.Tests
{
    public class BankAccountTests
    {
        public void ValidateDepositAmount()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(20);

            var expectedResult = 20;
            var actualResult = bankAccount.Amount;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
