using QBMS.Core.Domain;
using System.Collections.Generic;


namespace QBMS.Core.Interfaces.Repositories
{
    public interface IQuoteRepository
    {
        void Delete(Quote quote);
        Quote GetBy(int? quoteId);
        void Save(Quote quote);
        List<Quote> GetAll();
    }
}
