namespace AuthenticationService.DTOs
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public object ResponseBody { get; set; }
    }
}
