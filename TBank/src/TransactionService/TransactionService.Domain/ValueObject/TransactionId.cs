namespace TransactionService.Domain.ValueObject
{
    public record TransactionId
    {
        public Guid Value { get; init; }

        public TransactionId(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("TransactionId не может быть пустым");

            Value = value;
        }

        public static TransactionId New() => new(Guid.NewGuid());

        public override string ToString() => Value.ToString();
    }
}
