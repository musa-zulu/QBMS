using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    public class TestClient
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new Client());
        }

        [TestCase("Id", typeof(int))]
        [TestCase("FirstName", typeof(string))]
        [TestCase("Surname", typeof(string))]
        [TestCase("Email", typeof(string))]
        [TestCase("Title", typeof(Title))]
        [TestCase("TitleId", typeof(Guid))]
        [TestCase("ContactNumber", typeof(string))]

        public void Borrower_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof (Client);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
