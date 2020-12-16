using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_project_GXMRLU.Classes;


namespace UnitTestProject1
{
    class OrderValidate
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
            ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var orderchecker = new OrderChecker();

            // Act
            var actualResult = orderchecker.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
