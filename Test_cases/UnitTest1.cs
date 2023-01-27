using UserRegistration;

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
            UserRegistration ur = new UserRegistration();

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
            string expected = "abc@Xyz";
            string message = "Valid";
            string actual = userRegistration.validatePassword(expected);

            Assert.AreEqual(message, actual);
        }

        [TestMethod]
        public void invalidPassword()
        {
            string expected = "P1324ad";
            string message = "Invalid";
            string actual = userRegistration.validatePassword(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void validPhone()
        {
            string expected = "91 7708554905";
            string message = "Valid";
            string actual = userRegistration.validatePhone(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void invalidPhone()
        {
            string expected = "91 12345";
            string message = "Invalid";
            string actual = userRegistration.validatePhone(expected);

            Assert.AreEqual(message, actual);
        }
    }
}