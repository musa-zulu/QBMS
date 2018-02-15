using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    class TestAddress
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new Address());
        }
        [TestCase("Id", typeof(int))]
        [TestCase("HouseNumber", typeof(int))]
        [TestCase("StreetName", typeof(string))]
        [TestCase("Suburb", typeof(string))]
        [TestCase("City", typeof(string))]
        [TestCase("PostalCode", typeof(string))]
        [TestCase("CountryCode", typeof(string))]
        [TestCase("AddressType", typeof(AddressType))]
        public void Address_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Address);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }

    }
}
