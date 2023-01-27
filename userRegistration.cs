﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration2
{
    public class userRegistration
    {
        public static string validateFirstName(string f_name)
        {
            bool val_no = false;
            string f_name_pattern = "^[A-Z][a-z]{2,}$";

            do
            {

                val_no = Regex.IsMatch(f_name, f_name_pattern);
                if (val_no == false)
                {
                    return "Invalid";
                }
                else
                {
                    return "Valid";
                }


            } while (!val_no);
        }

        public static string validateLastName(string l_name)
        {
            bool val_no = false;
            string l_name_pattern = "^[a-z]{2,}[A-Z]$";

            do
            {

                val_no = Regex.IsMatch(l_name, l_name_pattern);
                if (val_no == false)
                {
                    return "Invalid";
                }
                else
                {
                    return "Valid";
                }

            } while (!val_no);
        }

        public static string validateEmail(string email)
        {
            bool val_no = false;
            string email_pattern = "[a-z]+([.][a-z]+)?[@][a-z]+[.][a-z]+([.][a-z]+)?";

            do
            {

                val_no = Regex.IsMatch(email, email_pattern);
                if (val_no == false)
                {
                    return "Invalid";
                }
                else
                {
                    return "Valid";
                }

            } while (!val_no);
        }

        public static string validatePhoneNum(string phone)
        {
            bool val_no = false;
            string phone_pattern = "^[0-9]{2}\\s[0-9]{10}$";

            do
            {

                val_no = Regex.IsMatch(phone, phone_pattern);
                if (val_no == false)
                {
                    return "Invalid";
                }
                else
                {
                    return "Valid";
                }

            } while (!val_no);
        }

        public static string validatePassword(string password)
        {
            bool val_no = false;
            string password_pattern = "^(?=.*?[A-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

            do
            {
                val_no = Regex.IsMatch(password, password_pattern);
                if (val_no == false)
                {
                    return "Invalid";
                }
                else
                {
                    return "Valid";
                }

            } while (!val_no);
        }
    }
}
