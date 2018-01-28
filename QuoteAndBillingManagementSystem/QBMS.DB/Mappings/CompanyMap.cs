using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Company = QBMS.DB.DataConstants.Tables.Company;

namespace QBMS.DB.Mappings
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Company.TableName);
            this.Property(p => p.Id).HasColumnName(_Company.Columns.CompanyId);
            this.Property(p => p.AddressId).HasColumnName(_Company.Columns.AddressId);
            this.Property(p => p.BankingDetailsId).HasColumnName(_Company.Columns.BankingDetailsId);
            this.Property(p => p.Cell).HasColumnName(_Company.Columns.Cell);
            this.Property(p => p.EmailAddress).HasColumnName(_Company.Columns.EmailAddress);
            this.Property(p => p.Phone).HasColumnName(_Company.Columns.Phone);
            this.Property(p => p.RegisteredName).HasColumnName(_Company.Columns.RegisteredName);
            this.Property(p => p.RegistrationNumber).HasColumnName(_Company.Columns.RegistrationNumber);
            this.Property(p => p.TradingName).HasColumnName(_Company.Columns.TradingName);
            this.Property(p => p.VatNumber).HasColumnName(_Company.Columns.VatNumber);
        }
    }
}
