using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    class TestBankingDetails
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new BankingDetails());
        }
        [TestCase("Id", typeof(int))]
        [TestCase("AccountNumber", typeof(string))]
        [TestCase("BankName", typeof(string))]
        [TestCase("BankBranch", typeof(string))]
        [TestCase("BankBranchCode", typeof(string))]
        public void BankingDetails_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(BankingDetails);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
