using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Client = QBMS.DB.DataConstants.Tables.Client;
namespace QBMS.DB.Mappings
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Client.TableName);
            this.Property(p => p.Id).HasColumnName(_Client.Columns.ClientId);
            this.Property(p => p.TitleId).HasColumnName(_Client.Columns.TitleId);
            this.Property(p => p.FirstName).HasColumnName(_Client.Columns.FirstName);
            this.Property(p => p.Surname).HasColumnName(_Client.Columns.Surname);
            this.Property(p => p.Email).HasColumnName(_Client.Columns.Email);
            this.Property(p => p.ContactNumber).HasColumnName(_Client.Columns.ContactNumber);
        }
    }
}