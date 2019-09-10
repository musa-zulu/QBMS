using System.Data.Common;
using System.Data.Entity;
using QBMS.Core.Domain;
using QBMS.DB.Mappings;

namespace QBMS.DB
{
    public interface IQBMSDbContext
    {
        int SaveChanges();
        void AttachEntity(EntityBase entity);
        IDbSet<Quote> Quotes { get; set; }
        IDbSet<Title> Titles { get; set; }
        IDbSet<ClientsQuoteItem> ClientsQuoteItems { get; set; }
        IDbSet<Roles> Roles { get; set; }
        IDbSet<Client> Clients { get; set; }
        IDbSet<Company> Companies { get; set; }
        IDbSet<Address> Addresses { get; set; }
        IDbSet<BankingDetails> BankingDetails { get; set; }
        IDbSet<Invoice> Invoices { get; set; }
        void SetStateToDelete(EntityBase entityList);
    }

    public class QBMSDbContext : DbContext, IQBMSDbContext
    {
        static QBMSDbContext()
        {
            Database.SetInitializer<QBMSDbContext>(null);
        }

        public QBMSDbContext(DbConnection connection) : base(connection, true)
        {         
        }
        public QBMSDbContext(string nameOrConnectionString = null)
            : base(nameOrConnectionString ?? "Name=QBMS")
        {
            // Data Source=MUSA;Initial Catalog=QBMS;User ID=sa
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var config = modelBuilder.Configurations;
            config.Add(new ClientMap());
            config.Add(new TitleMap());
            config.Add(new QuoteMap());
            config.Add(new ClientsQuoteItemMap());
            config.Add(new RoleMap());
            config.Add(new CompanyMap());
            config.Add(new AddressMap());
            config.Add(new BankingDetailsMap());
            config.Add(new InvoiceMap());
            base.OnModelCreating(modelBuilder);
        }

        public void AttachEntity(EntityBase entity)
        {
            Entry(entity).State = entity.IsNew() ? EntityState.Added : EntityState.Modified;
        }

        public IDbSet<Quote> Quotes { get; set; }
        public IDbSet<Title> Titles { get; set; }
        public IDbSet<ClientsQuoteItem> ClientsQuoteItems { get; set; }
        public IDbSet<Roles> Roles { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<BankingDetails> BankingDetails { get; set; }
        public IDbSet<Invoice> Invoices { get; set; }

        public void SetStateToDelete(EntityBase entityList)
        {
            Entry(entityList).State = entityList.Id == 0 ? EntityState.Detached : EntityState.Deleted;
        }
    }
}