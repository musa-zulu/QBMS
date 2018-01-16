using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _ClientsQuoteItems = QBMS.DB.DataConstants.Tables.ClientsQuoteItem;
namespace QBMS.DB.Mappings

{
    public class ClientsQuoteItemMap : EntityTypeConfiguration<ClientsQuoteItem>
    {
        public ClientsQuoteItemMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_ClientsQuoteItems.TableName);
            this.Property(p => p.Id).HasColumnName(_ClientsQuoteItems.Columns.ClientsQuoteItemId);
            this.Property(p => p.ClientId).HasColumnName(_ClientsQuoteItems.Columns.ClientId);
            this.Property(p => p.QuoteId).HasColumnName(_ClientsQuoteItems.Columns.QuoteId);
            this.Property(p => p.DateQuoted).HasColumnName(_ClientsQuoteItems.Columns.DateQuoted);
            this.Property(p => p.DateAccepted).HasColumnName(_ClientsQuoteItems.Columns.DateAccepted);
        }
    }
}