using FluentMigrator;
using _Title = QBMS.DB.DataConstants.Tables.Title;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801311846)]
    public class _201801311846_CreateTitleTable : Migration
    {
        public override void Up()
        {
            Create.Table(_Title.TableName)
                .WithColumn(_Title.Columns.TitleId).AsInt32().PrimaryKey("PK_TitleId").Identity()
                .WithColumn(_Title.Columns.Description).AsString(10)
                .WithDefaultEntityColumns();
        }

        public override void Down()
        {
            // No down migration
        }
    }
}