using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Invoice = QBMS.DB.DataConstants.Tables.Invoice;

namespace QBMS.DB.Mappings
{
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Invoice.TableName);
            this.Property(p => p.Id).HasColumnName(_Invoice.Columns.InvoiceId);
            this.Property(p => p.Description).HasColumnName(_Invoice.Columns.Description);
            this.Property(p => p.InvoiceDate).HasColumnName(_Invoice.Columns.InvoiceDate);
            this.Property(p => p.M_OR_S).HasColumnName(_Invoice.Columns.M_OR_S);
            this.Property(p => p.OrderNumber).HasColumnName(_Invoice.Columns.OrderNumber);
            this.Property(p => p.QTY).HasColumnName(_Invoice.Columns.QTY);
            this.Property(p => p.SubTotal).HasColumnName(_Invoice.Columns.SubTotal);
            this.Property(p => p.Total).HasColumnName(_Invoice.Columns.Total);
            this.Property(p => p.TotalDue).HasColumnName(_Invoice.Columns.TotalDue);
            this.Property(p => p.UnitPrice).HasColumnName(_Invoice.Columns.UnitPrice);
            this.Property(p => p.Vat).HasColumnName(_Invoice.Columns.Vat);
        }
    }
}