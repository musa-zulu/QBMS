using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Quote = QBMS.DB.DataConstants.Tables.Quote;
namespace QBMS.DB.Mappings
{
    public class QuoteMap : EntityTypeConfiguration<Quote>
    {
        public QuoteMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Quote.TableName);
            this.Property(p => p.Id).HasColumnName(_Quote.Columns.QuoteId);
            this.Property(p=>p.BillingAddres).HasColumnName(_Quote.Columns.BillingAddress);
            this.Property(p => p.Description).HasColumnName(_Quote.Columns.Description);
            
        }
    }
}