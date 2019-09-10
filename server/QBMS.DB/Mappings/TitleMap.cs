using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _Title = QBMS.DB.DataConstants.Tables.Title;

namespace QBMS.DB.Mappings
{
    public class TitleMap : EntityTypeConfiguration<Title>
    {
        public TitleMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_Title.TableName);
            this.Property(p => p.Id).HasColumnName(_Title.Columns.TitleId);
            this.Property(p => p.Description).HasColumnName(_Title.Columns.Description);
        }
    }
}