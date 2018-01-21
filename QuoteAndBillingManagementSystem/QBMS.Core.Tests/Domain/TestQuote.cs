using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;
using System.Collections.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    class TestQuote
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new Quote());
        }

        [TestCase("Id", typeof(int))]
        [TestCase("CompanyId", typeof(int))]
        [TestCase("Company", typeof(Company))]
        [TestCase("BillingAddres", typeof(string))]
        [TestCase("Description", typeof(string))]
        [TestCase("QuoteItems", typeof(ICollection<ClientsQuoteItem>))]
        public void Quote_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Quote);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
