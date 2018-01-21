using System;
using QBMS.Core.Domain;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    class TestInvoice
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new Invoice());
        }

        [TestCase("Id", typeof(Guid))]
        [TestCase("InvoiceDate", typeof(DateTime?))]
        [TestCase("Description", typeof(string))]
        [TestCase("QTY", typeof(int?))]
        [TestCase("UnitPrice", typeof(decimal?))]
        [TestCase("Total", typeof(decimal))]
        [TestCase("SubTotal", typeof(decimal))]
        [TestCase("Vat", typeof(string))]
        [TestCase("TotalDue", typeof(decimal))]
        [TestCase("OrderNumber", typeof(string))]
        [TestCase("M_OR_S", typeof(string))]
        [TestCase("CompanyId", typeof(Guid))]
        [TestCase("Company", typeof(Company))]
        public void Client_Property_ShouldExist(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Invoice);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
