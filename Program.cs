using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            userRegistration.validateFirstName();
            userRegistration.validateLastName();
            userRegistration.validateEmail();
            userRegistration.validatePhoneNum();
            userRegistration.validatePassword();
        }
    }
}
