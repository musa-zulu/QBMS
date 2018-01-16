using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Role = QBMS.DB.DataConstants.Tables.Roles;

namespace QBMS.DB.Mappings
{
    public class RoleMap : EntityTypeConfiguration<Roles>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Role.TableName);
            this.Property(p => p.Id).HasColumnName(_Role.Columns.RolesId);
            this.Property(p => p.Name).HasColumnName(_Role.Columns.Name);

        }
    }
}