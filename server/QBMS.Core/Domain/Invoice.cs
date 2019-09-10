using System;

namespace QBMS.Core.Domain
{
    public class Invoice : EntityBase
    {
        public DateTime? InvoiceDate { get; set; }
        public string Description { get; set; }
        public int? QTY { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public string Vat { get; set; }
        public decimal TotalDue { get; set; }
        public string OrderNumber { get; set; }
        public string M_OR_S { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
