namespace AuthWebAPIDemo.Models
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // this won't be stored anywhere. it would be used to pass the pw entered by user to api
    }
}
