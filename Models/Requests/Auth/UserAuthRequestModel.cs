namespace Shared.Models.Requests
{
    public class UserAuthRequestModel
    {
        public AuthStatus Status;
        public string? AuthMessage;
        public UserDTO? UserDto;

        public enum AuthStatus
        {
            WrongLoginData = 0,
            Banned = 1,
            Suspended = 2,
            Completed = 3
        }

        public UserAuthRequestModel()
        {

        }

        public UserAuthRequestModel(AuthStatus AuthStatus)
        {
            this.Status = AuthStatus;
        }

        public UserAuthRequestModel(AuthStatus AuthStatus, UserDTO userDTO)
        {
            this.Status = AuthStatus;
            this.UserDto = userDTO;
        }
        
    }
}
