using FluentMigrator;
using _Client = QBMS.DB.DataConstants.Tables.Client;
using _Title = QBMS.DB.DataConstants.Tables.Title;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801281816)]
    class _201801281816_CreateClientTable : Migration
    {        
        public override void Up()
        {
            Create.Table(_Client.TableName)
                .WithColumn(_Client.Columns.ClientId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_Client.Columns.FirstName).AsDateTime().Nullable()
                .WithColumn(_Client.Columns.Surname).AsDateTime().Nullable()
                .WithColumn(_Client.Columns.Email).AsString().Nullable()
                .WithColumn(_Client.Columns.ContactNumber).AsString().Nullable()
                .WithColumn(_Client.Columns.TitleId).AsInt32().NotNullable().ForeignKey("FK_Client_Title", _Title.TableName, _Title.Columns.TitleId)
                .WithDefaultEntityColumns();
        }

        public override void Down()
        {
        }
    }
}
