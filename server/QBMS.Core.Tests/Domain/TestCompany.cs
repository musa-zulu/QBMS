using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    class TestCompany
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new Company());
        }

        [TestCase("Id", typeof(int))]
        [TestCase("TradingName", typeof(string))]
        [TestCase("RegisteredName", typeof(string))]
        [TestCase("RegistrationNumber", typeof(string))]
        [TestCase("Cell", typeof(long))]
        [TestCase("Phone", typeof(long))]
        [TestCase("VatNumber", typeof(string))]
        [TestCase("EmailAddress", typeof(string))]
        [TestCase("BankingDetailsId", typeof(int))]
        [TestCase("AddressId", typeof(int))]
        [TestCase("Address", typeof(Address))]
        [TestCase("BankingDetails", typeof(BankingDetails))]
        public void Company_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Company);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}