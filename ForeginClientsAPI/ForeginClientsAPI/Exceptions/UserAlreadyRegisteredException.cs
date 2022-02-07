using System;

namespace ForeginClientsAPI.Exceptions
{
    public class UserAlreadyRegisteredException : Exception // when the User wants to register again on that same PESEL number
    {
        public UserAlreadyRegisteredException(string message) : base(message)
        {

        }
    }
}
