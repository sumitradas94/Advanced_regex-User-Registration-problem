using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase3()
        {
            string email = "abc.xyz@bl.co.in";
            bool expected = true;
            bool actual = Pattern.validateEmailID(email);
            Assert.AreEqual(expected, actual);
        }
    }
}