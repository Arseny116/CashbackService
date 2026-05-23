namespace TransactionService.Domain.ValueObject
{
    public record MccCode
    {
        public string Value { get; }

        public MccCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 4)
                throw new ArgumentException("MCC код должен состоять из 4 цифр");

            Value = value;
        }

        public override string ToString() => Value;
    }
}
