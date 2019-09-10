using System;
using FluentMigrator;
using _Title = QBMS.DB.DataConstants.Tables.Title;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201802111621)]
    public class _201802111621_PopulateTitleTable : MigrationBase
    {
        public override void Up()
        {
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Mr", Created = DateTime.Now.AddSeconds(-7) });
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Mrs", Created = DateTime.Now.AddSeconds(-6) });
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Dr", Created = DateTime.Now.AddSeconds(-5) });
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Prof", Created = DateTime.Now.AddSeconds(-4) });
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Ms", Created = DateTime.Now.AddSeconds(-3) });
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Miss", Created = DateTime.Now.AddSeconds(-2) });
            this.Insert.IntoTable(_Title.TableName).Row(new { Description = "Rev", Created = DateTime.Now.AddSeconds(-1) });
        }

        public override void Down()
        {
        }
    }
}