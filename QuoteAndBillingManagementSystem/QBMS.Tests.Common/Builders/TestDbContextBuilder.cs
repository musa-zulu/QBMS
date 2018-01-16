using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using NSubstitute;
using QBMS.Core.Domain;
using QBMS.DB;

namespace QBMS.Common.Builders
{
    public class TestDbContextBuilder
    {
        private List<Client> _clients = new List<Client>();
        private List<Title> _title = new List<Title>();
        private List<Quote> _quotes = new List<Quote>();
        private List<Roles> _roles = new List<Roles>();
        private List<ClientsQuoteItem> _clientsQuoteItem = new List<ClientsQuoteItem>();

        public TestDbContextBuilder WithClients(params Client[] clients)
        {
            _clients = clients.ToList();
            return this;
        }
        public TestDbContextBuilder WithTitles(params Title[] titles)
        {
            _title = titles.ToList();
            return this;
        }
        public TestDbContextBuilder WithQuotes (params Quote[] quotes)
        {
            _quotes = quotes.ToList();
            return this;
        }
        public TestDbContextBuilder WithClientsQuoteItem (params ClientsQuoteItem[] clientsQuoteItem)
        {
            _clientsQuoteItem = clientsQuoteItem.ToList();
            return this;
        }
        public TestDbContextBuilder WithRoles (params Roles[] roles)
        {
            _roles = roles.ToList();
            return this;
        }
        public IQBMSDbContext Build()
        {
            var iQBMSDbContext = Substitute.For<IQBMSDbContext>();
            SetupTitles(iQBMSDbContext);
            SetupClients(iQBMSDbContext);
            SetUpQuotes(iQBMSDbContext);
            SetUpClientsQuoteItems(iQBMSDbContext);
            SetUpRoles(iQBMSDbContext);
            return iQBMSDbContext;
        }
        private void SetUpQuotes(IQBMSDbContext iQBMSDbContext)
        {
            if (_quotes != null)
            {
                var set = GetSubstituteDbSet<Quote>().SetupData(_quotes);
                iQBMSDbContext.Quotes.Returns(set);
            }
        }
        private void SetUpRoles(IQBMSDbContext iQBMSDbContext)
        {
            if (_roles != null)
            {
                var set = GetSubstituteDbSet<Roles>().SetupData(_roles);
                iQBMSDbContext.Roles.Returns(set);
            }
        }
        private void SetUpClientsQuoteItems(IQBMSDbContext iQBMSDbContext)
        {
            if (_clientsQuoteItem != null)
            {
                var set = GetSubstituteDbSet<ClientsQuoteItem>().SetupData(_clientsQuoteItem);
                iQBMSDbContext.ClientsQuoteItems.Returns(set);
            }
        }
        private void SetupClients(IQBMSDbContext iQBMSDbContext)
        {
            if (_clients != null)
            {
                var set = GetSubstituteDbSet<Client>().SetupData(_clients);
                iQBMSDbContext.Clients.Returns(set);
            }
        }
        private void SetupTitles(IQBMSDbContext iQBMSDbContext)
        {
            if (_title != null)
            {
                var set = GetSubstituteDbSet<Title>().SetupData(_title);
                iQBMSDbContext.Titles.Returns(set);
            }
        }        
        private DbSet<T> GetSubstituteDbSet<T>() where T : class
        {
            return Substitute.For<DbSet<T>, IQueryable<T>, IDbAsyncEnumerable<T>>();
        }
    }
}