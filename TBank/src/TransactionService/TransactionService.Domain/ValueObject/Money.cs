namespace TransactionService.Domain.ValueObject
{
    // Позиционный синтаксис 
    public record Money(decimal Amount, Currency currency) { };
}
