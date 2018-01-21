using System;
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
        void SetStateToDelete(EntityBase entityList);
    }

    public class QBMSDbContext : DbContext, IQBMSDbContext
    {
        public QBMSDbContext(DbConnection connection) : base(connection, true)
        {
            
        }
        public QBMSDbContext(string nameOrConnectionString = "DefaultConnection") : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var config = modelBuilder.Configurations;
            config.Add(new ClientMap());
            config.Add(new TitleMap());
            config.Add(new QuoteMap());
            config.Add(new ClientsQuoteItemMap());
            config.Add(new RoleMap());
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

        public void SetStateToDelete(EntityBase entityList)
        {
            Entry(entityList).State = entityList.Id == 0 ? EntityState.Detached : EntityState.Deleted;
        }
    }
}