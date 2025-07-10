

namespace Banking.Domain;

public struct TransactionAmount
{
    public decimal Value { get; private set; }

    private TransactionAmount (decimal value)
    {
        Value = value;
    }
    // Factory Method

    public static TransactionAmount FromDecimal (decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidTransactionAmountException();
        }
        return new TransactionAmount (amount);
    }
}

public class InvalidTransactionAmountException : ArgumentOutOfRangeException;