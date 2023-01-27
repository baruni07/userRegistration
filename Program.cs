using System;

namespace UserRegistration2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter user f_name: ");
            string f_name = Console.ReadLine();
            userRegistration.validateFirstName(f_name);

            Console.Write("Enter user l_name: ");
            string l_name = Console.ReadLine();
            userRegistration.validateLastName(l_name);

            Console.Write("Enter user email: ");
            string email = Console.ReadLine();
            userRegistration.validateEmail(email);

            Console.Write("Enter user phone: ");
            string phone = Console.ReadLine();
            userRegistration.validatePhoneNum(phone);

            Console.Write("Enter user password: ");
            string password = Console.ReadLine();
            userRegistration.validatePassword(password);
        }
    }
}
