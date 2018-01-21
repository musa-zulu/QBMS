using System;
using System.Collections.Generic;

namespace QBMS.Core.Domain
{
    public class Quote : EntityBase
    {
        public string BillingAddres { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<ClientsQuoteItem> QuoteItems { get; set; }
    }
}
