namespace AuthWebAPIDemo.Models
{
    public class TokenResponseDto
    {
        public string RefreshToken { get; set; } = string.Empty;
        public string AccessToken { get; set; } = string.Empty;    
    }
}
