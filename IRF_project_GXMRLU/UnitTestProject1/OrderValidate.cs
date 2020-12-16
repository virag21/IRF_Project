using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_project_GXMRLU;


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


        [
            Test,
            TestCase("+35501061811", false),
            TestCase("0625110157", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("+36201071511", true),
            TestCase("0613160510", true),
            TestCase("06707563951", true)
            ]
        public void TestValidatePhone(string phone, bool expectedResult)
        {
            var orderchecker = new OrderChecker();

            // Act
            var actualResult = orderchecker.ValidatePhone(phone);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
