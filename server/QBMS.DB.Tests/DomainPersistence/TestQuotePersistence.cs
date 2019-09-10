using System;
using System.CodeDom;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using NUnit.Framework;
using QBMS.Tests.Common.Builders;
using NUnit.Framework.Constraints;
using PeanutButter.TempDb.LocalDb;
using PeanutButter.TestUtils.Generic;
using QBMS.Core.Domain;

namespace QBMS.DB.Tests.DomainPersistence
{
    [TestFixture]
    public class TestQuotePersistence
    {
        private TempDBLocalDb _localDb;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _localDb = new TempDBLocalDb();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _localDb?.Dispose();
        }

      //  [Test]
        public void Borrower_ShouldPersistAndRecall()
        {
            //---------------Set up test pack-------------------
            var quote = new QuoteBuilder()
                                .WithRandomProps()
                                .WithProp(b => b.Id = 0)
                                .WithValidCompanyId()
                                .Build();
            //---------------Assert Precondition----------------

            using (var ctx = new QBMSDbContext(_localDb.CreateConnection()))
            {
                //ctx.Set<Quote>().Add(quote);
                //ctx.Set(typeof (Quote)).Add(quote);
                //ctx.Set(quote.GetType()).Add(quote);
                //ctx.Entry(quote).State = EntityState.Added;

                ctx.Quotes.Add(quote);
                ctx.SaveChanges();
            }

            using (var ctx = new QBMSDbContext(_localDb.CreateConnection()))
            {
                //---------------Execute Test ----------------------
                var result = ctx.Set<Quote>().Single();
                //---------------Test Result -----------------------
                PropertyAssert.AreEqual(quote, result, "Company");
            }
        }
    }
}