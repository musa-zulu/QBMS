using FluentMigrator;
using _Address = QBMS.DB.DataConstants.Tables.Address;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801291934)]
    public class _201801291934_CreateAddressTable : Migration
    {
        public override void Up()
        {
            Create.Table(_Address.TableName)
                .WithColumn(_Address.Columns.AddressId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_Address.Columns.HouseNumber).AsString().Nullable()
                .WithColumn(_Address.Columns.StreetName).AsString().Nullable()
                .WithColumn(_Address.Columns.Suburb).AsString().Nullable()
                .WithColumn(_Address.Columns.City).AsString().Nullable()
                .WithColumn(_Address.Columns.PostalCode).AsString().Nullable()
                .WithColumn(_Address.Columns.CountryCode).AsString().Nullable()
                .WithColumn(_Address.Columns.AddressType).AsInt32().Nullable()
                .WithDefaultEntityColumns();                
        }

        public override void Down()
        {
        }
    }
}
