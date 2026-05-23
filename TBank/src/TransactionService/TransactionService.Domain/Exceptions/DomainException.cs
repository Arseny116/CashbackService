namespace TransactionService.Domain.Exceptions
{
    public class DomainException : Exception
    {
      
        public string ErrorCode { get; }

        
        public DomainException(string message)
            : base(message)  //  передаем в стандартный Exception
        {
            ErrorCode = "DOMAIN_ERROR";  //  код по умолчанию
        }

       
        public DomainException(string message, string errorCode)
            : base(message)  // ← опять в Exception
        {
            ErrorCode = errorCode;  //  конкретный код
        }

        
        public DomainException(string message, Exception inner)
            : base(message, inner)  // ← оборачиваем другое исключение
        {
            ErrorCode = "DOMAIN_ERROR";
        }
    }
}
