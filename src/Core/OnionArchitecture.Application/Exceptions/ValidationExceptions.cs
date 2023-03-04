namespace OnionArchitecture.Application.Exceptions
{
    public class ValidationExceptions : Exception
    {
        public ValidationExceptions() : this("One or more validation failures have occurred")
        {

        }
        public ValidationExceptions(string message) : base(message)
        {

        }
        public ValidationExceptions(Exception ex) : this(ex.Message)
        {

        }
    }
}
