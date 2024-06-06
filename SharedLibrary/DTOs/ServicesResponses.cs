

namespace SharedLibrary.DTOs
{
    //response after user successfully logs in /registers
    public class ServicesResponses
    {
        public record class GeneralResponse (bool Flag, string Message);
        public record class  LoginResponse(bool Flag, string Token, string Message);
    }
}
