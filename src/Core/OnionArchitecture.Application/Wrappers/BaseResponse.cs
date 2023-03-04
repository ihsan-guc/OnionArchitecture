namespace OnionArchitecture.Application.Wrappers
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Succeeded = true;
            Message = string.Empty;
        }

        public BaseResponse(string message)
        {
            Succeeded = true;
            Message = message;
        }

        public BaseResponse(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
