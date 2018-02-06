using FluentMigrator;
using _Table = QBMS.DB.DataConstants.Tables.ClientsQuoteItem;
using _Client = QBMS.DB.DataConstants.Tables.Client;
using _Quote = QBMS.DB.DataConstants.Tables.Quote;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801281753)]
    class _201801281753_CreateClientsQuoteItemTable : Migration
    {
        public override void Up()
        {
            Create.Table(_Table.TableName)
                .WithColumn(_Table.Columns.ClientsQuoteItemId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_Table.Columns.DateAccepted).AsDateTime().Nullable()
                .WithColumn(_Table.Columns.DateQuoted).AsDateTime().NotNullable()
                .WithColumn(_Table.Columns.QuoteId).AsInt32().NotNullable().ForeignKey("FK_ClientsQuoteItem_Quote", _Quote.TableName, _Quote.Columns.QuoteId)
                .WithColumn(_Table.Columns.ClientId).AsInt32().NotNullable().ForeignKey("FK_ClientsQuoteItem_Client", _Client.TableName, _Client.Columns.ClientId)
                .WithDefaultEntityColumns();                
        }

        public override void Down()
        {
        }
    }
}
