using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class userRegistration
    {
        public static void validateFirstName()
        {
            bool val_no = false;
            string f_name_pattern = "^[A-Z][a-z]{2,}$";

            do
            {
                Console.Write("Enter user f_name: ");
                string f_name = Console.ReadLine();
                val_no = Regex.IsMatch(f_name, f_name_pattern);

            } while (!val_no);
        }

        public static void validateLastName()
        {
            bool val_no = false;
            string l_name_pattern = "^[a-z]{2,}[A-Z]$";

            do
            {
                Console.Write("Enter user l_name: ");
                string l_name = Console.ReadLine();
                val_no = Regex.IsMatch(l_name, l_name_pattern);

            } while (!val_no);
        }

        public static void validateEmail()
        {
            bool val_no = false;
            string email_pattern = "[a-z]+([.][a-z]+)?[@][a-z]+[.][a-z]+([.][a-z]+)?";

            do
            {
                Console.Write("Enter user email: ");
                string email = Console.ReadLine();
                val_no = Regex.IsMatch(email, email_pattern);

            } while (!val_no);
        }

        public static void validatePhoneNum()
        {
            bool val_no = false;
            string phone_pattern = "^[0-9]{2}\\s[0-9]{10}$";

            do
            {
                Console.Write("Enter user phone: ");
                string phone = Console.ReadLine();
                val_no = Regex.IsMatch(phone, phone_pattern);

            } while (!val_no);
        }

        public static void validatePassword()
        {
            bool val_no = false;
            string password_pattern = "^(?=.*?[A-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

            do
            {
                Console.Write("Enter user password: ");
                string password = Console.ReadLine();
                val_no = Regex.IsMatch(password, password_pattern);

            } while (!val_no);
        }


    }
}
