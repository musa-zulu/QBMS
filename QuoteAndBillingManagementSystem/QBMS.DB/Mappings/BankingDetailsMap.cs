using System.Data.Entity.ModelConfiguration;
using QBMS.Core.Domain;
using _BankingDetailsMap = QBMS.DB.DataConstants.Tables.BankingDetails;

namespace QBMS.DB.Mappings
{
    public class BankingDetailsMap : EntityTypeConfiguration<BankingDetails>
    {
        public BankingDetailsMap()
        {
            // Primary Key
            this.HasKey(s => s.Id);

            // Properties

            // table and column mappings
            this.ToTable(_BankingDetailsMap.TableName);
            this.Property(p => p.Id).HasColumnName(_BankingDetailsMap.Columns.BankingDetailsId);
            this.Property(p => p.AccountNumber).HasColumnName(_BankingDetailsMap.Columns.AccountNumber);
            this.Property(p => p.BankBranch).HasColumnName(_BankingDetailsMap.Columns.BankBranch);
            this.Property(p => p.BankBranchCode).HasColumnName(_BankingDetailsMap.Columns.BankBranchCode);
            this.Property(p => p.BankName).HasColumnName(_BankingDetailsMap.Columns.BankName);
        }
    }
}
