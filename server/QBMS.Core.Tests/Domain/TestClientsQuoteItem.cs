using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    class TestClientsQuoteItem
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new ClientsQuoteItem());
        }

        [TestCase("Id", typeof(int))]
        [TestCase("ClientId", typeof(int))]
        [TestCase("Client", typeof(Client))]
        [TestCase("QuoteId", typeof(int))]
        [TestCase("Quote", typeof(Quote))]
        [TestCase("DateQuoted", typeof(DateTime))]
        [TestCase("DateAccepted", typeof(DateTime?))]

        public void ClientsQuoteItem_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(ClientsQuoteItem);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
