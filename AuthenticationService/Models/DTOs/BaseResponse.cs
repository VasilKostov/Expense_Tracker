namespace AuthenticationService.Models.DTOs
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        //public string ErrorMessage = 
        public object ResponseBody { get; set; }
    }
}
