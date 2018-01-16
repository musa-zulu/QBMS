using System;

namespace QBMS.Core.Domain
{
    public class ClientsQuoteItem : EntityBase
    {
        public Guid ClientId { get; set; } 
        public virtual Client Client { get; set; }
        public Guid QuoteId { get; set; }
        public virtual Quote Quote { get; set; } 
        public DateTime DateQuoted { get; set; }
        public DateTime? DateAccepted { get; set; }
    }
}
