using FluentMigrator;
using _Company = QBMS.DB.DataConstants.Tables.Company;
using _Invoice = QBMS.DB.DataConstants.Tables.Invoice;

namespace QBMS.DB.Migrations.Migrations
{
    [Migration(201801311835)]
    class _201801311835_CreateInvoiceTable : Migration
    {
        public override void Up()
        {
            Create.Table(_Invoice.TableName)
                .WithColumn(_Invoice.Columns.InvoiceId).AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn(_Invoice.Columns.InvoiceDate).AsDateTime().Nullable()
                .WithColumn(_Invoice.Columns.Description).AsString().Nullable()
                .WithColumn(_Invoice.Columns.QTY).AsInt32().Nullable()
                .WithColumn(_Invoice.Columns.UnitPrice).AsDecimal().Nullable()
                .WithColumn(_Invoice.Columns.Total).AsDecimal().Nullable()
                .WithColumn(_Invoice.Columns.SubTotal).AsDecimal().Nullable()
                .WithColumn(_Invoice.Columns.Vat).AsString().Nullable()
                .WithColumn(_Invoice.Columns.TotalDue).AsDecimal().Nullable()
                .WithColumn(_Invoice.Columns.OrderNumber).AsDecimal().Nullable()
                .WithColumn(_Invoice.Columns.M_OR_S).AsDecimal().Nullable()
                .WithColumn(_Invoice.Columns.CompanyId).AsInt32().NotNullable().ForeignKey("FK_Invoice_Company", _Company.TableName, _Company.Columns.CompanyId)
                .WithDefaultEntityColumns();
        }

        public override void Down()
        {
        }
    }
}