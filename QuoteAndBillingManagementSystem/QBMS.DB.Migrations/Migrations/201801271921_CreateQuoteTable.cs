using FluentMigrator;
using _Company = QBMS.DB.DataConstants.Tables.Company;
using _Quote = QBMS.DB.DataConstants.Tables.Quote;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801271921)]
    class _201801271921_CreateQuoteTable : Migration
    {
        public override void Up()
        {
            Create.Table(_Quote.TableName)
                .WithColumn(_Quote.Columns.QuoteId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_Quote.Columns.BillingAddress).AsString().Nullable()
                .WithColumn(_Quote.Columns.Description).AsString().Nullable()
                .WithColumn(_Quote.Columns.CompanyId).AsInt32().NotNullable().ForeignKey("FK_Quote_Company", _Company.TableName, _Company.Columns.CompanyId)
                .WithDefaultEntityColumns();
        }

        public override void Down()
        {
        }
    }
}