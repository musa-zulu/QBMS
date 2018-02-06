using FluentMigrator;
using _Table = QBMS.DB.DataConstants.Tables.Company;
using _BankingDetails = QBMS.DB.DataConstants.Tables.BankingDetails;
using _Address = QBMS.DB.DataConstants.Tables.Address;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801292001)]
    class _201801292001_CreateCompanyTable : Migration
    {
        public override void Up()
        {
            Create.Table(_Table.TableName)
                .WithColumn(_Table.Columns.CompanyId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_Table.Columns.TradingName).AsString().Nullable()
                .WithColumn(_Table.Columns.RegistrationNumber).AsString().Nullable()
                .WithColumn(_Table.Columns.Cell).AsInt64().Nullable()
                .WithColumn(_Table.Columns.Phone).AsInt64().Nullable()
                .WithColumn(_Table.Columns.VatNumber).AsString().Nullable()
                .WithColumn(_Table.Columns.EmailAddress).AsString().Nullable()                
                .WithColumn(_Table.Columns.BankingDetailsId).AsInt32().NotNullable().ForeignKey("FK_Company_BsnkingDetails", _BankingDetails.TableName, _BankingDetails.Columns.BankingDetailsId)
                .WithColumn(_Table.Columns.AddressId).AsInt32().NotNullable().ForeignKey("FK_Company_Address", _Address.TableName, _Address.Columns.AddressId)
                .WithDefaultEntityColumns();
        }

        public override void Down()
        {
        }
    }
}
