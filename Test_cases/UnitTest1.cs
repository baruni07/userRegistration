using UserRegistration2;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validFirstName()
        {
            string expected = "Baruni";
            string message = "Valid";
            string actual = userRegistration.validateFirstName(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void invalidFirstName()
        {
            string expected = "Bk";
            string message = "Invalid";

            string actual = userRegistration.validateFirstName(expected);

            Assert.AreEqual(message, actual);
        }

        [TestMethod]
        public void validLastName()
        {
            string expected = "karthiK";
            string message = "Valid";

            string actual = userRegistration.validateLastName(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void invalidLastName()
        {
            string expected = "karthik";
            string message = "Invalid";

            string actual = userRegistration.validateLastName(expected);

            Assert.AreEqual(message, actual);
        }

        [TestMethod]
        public void validEmail()
        {
            string expected = "abc.xyz@bl.co.in";
            string message = "Valid";

            string actual = userRegistration.validateEmail(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void validPassword()
        {
            string expected = "abc@Xyzy1";
            string message = "Valid";
            string actual = userRegistration.validatePassword(expected);

            Assert.AreEqual(message, actual);
        }

        [TestMethod]
        public void invalidPassword()
        {
            string expected = "123456";
            string message = "Invalid";
            string actual = userRegistration.validatePassword(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void validPhone()
        {
            string expected = "91 7708554905";
            string message = "Valid";
            string actual = userRegistration.validatePhoneNum(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void invalidPhone()
        {
            string expected = "91 12345";
            string message = "Invalid";
            string actual = userRegistration.validatePhoneNum(expected);

            Assert.AreEqual(message, actual);
        }
    }
}
