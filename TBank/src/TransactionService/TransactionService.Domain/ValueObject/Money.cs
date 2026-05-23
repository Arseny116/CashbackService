namespace TransactionService.Domain.ValueObject
{
    // Позиционный синтаксис public record Money(decimal Amount, string Currency = "RUB") 
    public record Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency = "RUB")
        {
            if (amount < 0)
                throw new ArgumentException("Сумма не может быть отрицательной");
            Amount = amount;
            Currency = currency;
        }

        public static Money Zero => new(0);

        public Money Add(Money other)
        {
            if (Currency != other.Currency)
                throw new ArgumentException("Нельзя складывать разные валюты");
            return new Money(Amount + other.Amount, Currency);
        }

        public override string ToString() => $"{Amount} {Currency}";
    }
}
