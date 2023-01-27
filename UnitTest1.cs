using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {
            string name = "Sneha";
            bool expected = true;
            bool actual = Pattern.validateName(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase2()
        {
            string lastname = "Ram";
            bool expected = true;
            bool actual = Pattern.validateLastName(lastname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase3()
        {
            string email = "abc.xyz@bl.co.in";
            bool expected = true;
            bool actual = Pattern.validateEmailID(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase4()
        {
            string mb = "91 9420202094";
            bool expected = true;
            bool actual = Pattern.validateMobileNumber(mb);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UseCase5()
        {
            string password = "Snehasne";
            bool expected = true;
            bool actual = Pattern.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase6()
        {
            string password = "Snehasne";
            bool expected = true;
            bool actual = Pattern.validatePassword1(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase7()
        {
            string password = "Snehasn7";
            bool expected = true;
            bool actual = Pattern.validatePassword2(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase8()
        {
            string password = "Snehas7@";
            bool expected = true;
            bool actual = Pattern.validatePassword3(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase9()
        {
            string email1 = "abc.xyz@gmail.com";
            bool expected = true;
            bool actual = Pattern.validateEmailID1(email1);
            Assert.AreEqual(expected, actual);
        }
    }
}
