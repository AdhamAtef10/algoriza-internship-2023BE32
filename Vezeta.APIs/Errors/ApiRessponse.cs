namespace Vezeta.APIs.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public ApiResponse(int sattusCode, string? message = null)
        {
            StatusCode = sattusCode;
            Message = message ?? GetDefaultMessageForStatusCode(StatusCode);
        }

        private string? GetDefaultMessageForStatusCode(object statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "You are not authorized",
                404 => "Resource was not found",
                500 => "Errors are the path to the dark side. Errors lead to anger. anger leades to hate. Hate leads to career change :):(:",
                _ => null
            };
        }
    }
}
