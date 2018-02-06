using FluentMigrator;
using _BankingDetails = QBMS.DB.DataConstants.Tables.BankingDetails;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801281955)]
    class _201801281955_CreateBankingDetails : Migration
    {
        public override void Up()
        {
            Create.Table(_BankingDetails.TableName)
                .WithColumn(_BankingDetails.Columns.BankingDetailsId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_BankingDetails.Columns.AccountNumber).AsString().Nullable()
                .WithColumn(_BankingDetails.Columns.BankName).AsString().Nullable()
                .WithColumn(_BankingDetails.Columns.BankBranch).AsString().Nullable()
                .WithColumn(_BankingDetails.Columns.BankBranchCode).AsString().Nullable()
                .WithDefaultEntityColumns();
        }

        public override void Down()
        {
        }
    }
}
