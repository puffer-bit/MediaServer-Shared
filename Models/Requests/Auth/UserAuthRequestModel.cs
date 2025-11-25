using Shared.Models.DTO;

namespace Shared.Models.Requests
{
    public class UserAuthRequestModel
    {
        public AuthStatus Status;
        public string? CoordinatorInstanceId;
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

        public UserAuthRequestModel(AuthStatus authStatus)
        {
            this.Status = authStatus;
        }

        public UserAuthRequestModel(AuthStatus authStatus, UserDTO userDTO, string coordinatorInstanceId)
        {
            this.Status = authStatus;
            this.UserDto = userDTO;
            this.CoordinatorInstanceId = coordinatorInstanceId;
        }
        
    }
}
