

using SharedLibrary.DTOs;
using static SharedLibrary.DTOs.ServicesResponses;

namespace SharedLibrary.Contracts
{
   public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);

    }
}
