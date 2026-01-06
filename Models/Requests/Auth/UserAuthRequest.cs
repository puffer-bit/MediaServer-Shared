using Shared.Models.DTO;

namespace Shared.Models.Requests.Auth
{
    public class UserAuthRequest
    {
        public string? Password;
        public string? UserIdentity;

        public UserAuthRequest(string? password)
        {
            Password = password;
        }
        
        public UserAuthRequest(string? userIdentity, string? password)
        {
            UserIdentity = userIdentity;
            Password = password;
        }
    }
}
