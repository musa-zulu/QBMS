using System;
using System.Linq;
using QBMS.Core.Interfaces.Repositories;
using QBMS.DB.Repositories;
using QBMS.Tests.Common.Builders;
using NSubstitute;
using NUnit.Framework;
using System.Data.Entity;
using QBMS.Core.Domain;
using System.Collections.Generic;
using QBMS.Tests.Common.Helpers;

namespace QBMS.DB.Tests.Repositories
{
    public class TestQuotepository
    {

        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new QuoteRepository(Substitute.For<IQBMSDbContext>()));
        }

        [Test]
        public void Construct_GivenIQBMSDBContextIsNull_ShouldThrow()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var ex = Assert.Throws<ArgumentNullException>(() => new QuoteRepository(null));
            //---------------Test Result -----------------------
            Assert.AreEqual("iQBMSDbContext", ex.ParamName);
        }

        [Test]
        public void GetAll_GivenNoQuotesExistInRepository_ShouldShouldReturnEmptyList()
        {
            //---------------Set up test pack-------------------
            var repository = CreateQuoteRepository();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = repository.GetAll();
            //---------------Test Result -----------------------
            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetAll_GivenOneQouteExistsInRepository_ShouldReturnThatQuoteItem()
        {
            //---------------Set up test pack-------------------
            var quote = new QuoteBuilder().WithRandomProps().Build();
            var dbSet = CreateFakeDbSet(quote);
            var qBMSDbContext = CreateQBMSDbContext(dbSet);
            var repository = CreateQuoteRepository(qBMSDbContext);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = repository.GetAll();
            //---------------Test Result -----------------------
            Assert.AreEqual(1, results.Count());
        }

        [Test]
        public void Save_GivenInvalidQuoteObject_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var repository = CreateQuoteRepository();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var ex = Assert.Throws<ArgumentNullException>(() => repository.Save(null));
            //---------------Test Result -----------------------
            Assert.AreEqual("quote", ex.ParamName);
        }

        [Test]
        public void Save_GivenValidQuoteObject_ShouldSaveToRepo()
        {
            //---------------Set up test pack-------------------          
            var quote = new QuoteBuilder().WithRandomProps().Build();
            var dbSet = CreateFakeDbSet(quote);
            var qBMSDbContext = CreateQBMSDbContext(dbSet);
            var repository = CreateQuoteRepository(qBMSDbContext);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            repository.Save(quote);
            //---------------Test Result -----------------------
            var quotesFromRepo = repository.GetAll();
            Assert.AreEqual(1, quotesFromRepo.Count);
            Assert.AreEqual(quote.Id, quotesFromRepo.First().Id);
            Assert.AreEqual(quote.Id, quotesFromRepo.First().Id);
            Assert.AreEqual(quote.CompanyId, quotesFromRepo.First().CompanyId);
            CollectionAssert.Contains(quotesFromRepo, quote);
        }

        [Test]
        public void Save_GivenValidQuoteObject_ShouldCallSaveChanges()
        {
            //---------------Set up test pack-------------------
            var quote = QuoteBuilder.BuildRandom();
            var qBMSDbContext = CreateQBMSDbContext();
            var repository = CreateQuoteRepository(qBMSDbContext);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            repository.Save(quote);
            //---------------Test Result -----------------------
            qBMSDbContext.Received().SaveChanges();
        }

        [Test]
        public void GetBy_GivenInvalidId_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var iQBMSDbContext = CreateQBMSDbContext();
            var repository = CreateQuoteRepository(iQBMSDbContext);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var ex = Assert.Throws<ArgumentNullException>(() => repository.GetBy(null));
            //---------------Test Result -----------------------
            Assert.AreEqual("quoteId", ex.ParamName);
        }

        [Test]
        public void GetBy_GivenQuoteExist_ShouldReturnThatQuote()
        {
            //---------------Set up test pack-------------------
            var quote = QuoteBuilder.BuildRandom();
            var dbSet = CreateFakeDbSet(quote);
            var qBMSDbContext = CreateQBMSDbContext(dbSet);
            var repository = CreateQuoteRepository(qBMSDbContext);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = repository.GetBy(quote.Id);
            //---------------Test Result -----------------------
            Assert.AreEqual(quote, results);
        }
                
        [Test]
        public void Delete_InvalidQuoteObject_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var qBMSDbContext = CreateQBMSDbContext();
            var repository = CreateQuoteRepository(qBMSDbContext);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var ex = Assert.Throws<ArgumentNullException>(() => repository.Delete(null));
            //---------------Test Result -----------------------
            Assert.AreEqual("quote", ex.ParamName);
        }

        [Test]
        public void Delete_GivenValidQuoteObject_ShouldDeleteQuoteObject()
        {
            //---------------Set up test pack-------------------
            var quote = QuoteBuilder.BuildRandom();
            var dbSet = CreateFakeDbSet(quote);
            var qBMSDbContext = CreateQBMSDbContext(dbSet);
            var repository = CreateQuoteRepository(qBMSDbContext);
            //---------------Assert Precondition----------------
            Assert.AreEqual(1, qBMSDbContext.Quotes.Count());
            //---------------Execute Test ----------------------
            repository.Delete(quote);
            //---------------Test Result -----------------------
            var quotes = repository.GetAll();
            Assert.AreEqual(0, quotes.Count);
        }

        private static FakeDbSet<Quote> CreateFakeDbSet(Quote quote = null)
        {
            return new FakeDbSet<Quote> { quote };
        }

        private static QuoteRepository CreateQuoteRepository(IQBMSDbContext iQBMSDbContext = null)
        {
            if (iQBMSDbContext == null)
            {
                iQBMSDbContext = Substitute.For<IQBMSDbContext>();
            }
            return new QuoteRepository(iQBMSDbContext);
        }

        private static IDbSet<Quote> CreateDbSetWithAddRemoveSupport(List<Quote> quotes)
        {
            var dbSet = Substitute.For<IDbSet<Quote>>();

            dbSet.Add(Arg.Any<Quote>()).Returns(info =>
            {
                quotes.Add(info.ArgAt<Quote>(0));
                return info.ArgAt<Quote>(0);
            });

            dbSet.Remove(Arg.Any<Quote>()).Returns(info =>
            {
                quotes.Remove(info.ArgAt<Quote>(0));
                return info.ArgAt<Quote>(0);
            });

            dbSet.GetEnumerator().Returns(info => quotes.GetEnumerator());
            return dbSet;
        }

        private static IQBMSDbContext CreateQBMSDbContext(IDbSet<Quote> dbSet = null)
        {
            if (dbSet == null) dbSet = CreateDbSetWithAddRemoveSupport(new List<Quote>());
            var iQBMSDbContext = Substitute.For<IQBMSDbContext>();
            iQBMSDbContext.Quotes.Returns(info => dbSet);
            return iQBMSDbContext;
        }
    }
}