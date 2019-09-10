using System;
using System.Collections.Generic;
using System.Linq;
using QBMS.Core.Domain;
using QBMS.Core.Interfaces.Repositories;

namespace QBMS.DB.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly IQBMSDbContext _iQBMSDbContext;

        public QuoteRepository(IQBMSDbContext iQBMSDbContext)
        {
            _iQBMSDbContext = iQBMSDbContext ?? throw new ArgumentNullException(nameof(iQBMSDbContext));
        }

        public void Delete(Quote quote)
        {
            if (quote == null) throw new ArgumentNullException(nameof(quote));            
            _iQBMSDbContext.Quotes.Remove(quote);
            _iQBMSDbContext.SaveChanges();
        }

        public Quote GetBy(int? quoteId)
        {
            if (quoteId == null) throw new ArgumentNullException(nameof(quoteId));
            return _iQBMSDbContext.Quotes.FirstOrDefault(x => x.Id == quoteId);
        }

        public List<Quote> GetAll() => _iQBMSDbContext.Quotes.ToList();

        public void Save(Quote quote)
        {
            if (quote == null) throw new ArgumentNullException(nameof(quote));
            _iQBMSDbContext.AttachEntity(quote);
            _iQBMSDbContext.SaveChanges();
        }
    }
}
