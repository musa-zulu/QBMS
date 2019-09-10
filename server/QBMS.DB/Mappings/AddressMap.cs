using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Address = QBMS.DB.DataConstants.Tables.Address;
namespace QBMS.DB.Mappings
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Address.TableName);
            this.Property(p => p.Id).HasColumnName(_Address.Columns.AddressId);
            this.Property(p => p.AddressType).HasColumnName(_Address.Columns.AddressType);
            this.Property(p => p.City).HasColumnName(_Address.Columns.City);
            this.Property(p => p.CountryCode).HasColumnName(_Address.Columns.CountryCode);
            this.Property(p => p.HouseNumber).HasColumnName(_Address.Columns.HouseNumber);
            this.Property(p => p.PostalCode).HasColumnName(_Address.Columns.PostalCode);
            this.Property(p => p.StreetName).HasColumnName(_Address.Columns.StreetName);
            this.Property(p => p.Suburb).HasColumnName(_Address.Columns.Suburb);
        }
    }
}
