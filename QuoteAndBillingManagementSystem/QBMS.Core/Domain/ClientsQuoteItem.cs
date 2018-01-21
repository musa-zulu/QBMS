using System;

namespace QBMS.Core.Domain
{
    public class ClientsQuoteItem : EntityBase
    {
        public int ClientId { get; set; } 
        public virtual Client Client { get; set; }
        public int QuoteId { get; set; }
        public virtual Quote Quote { get; set; } 
        public DateTime DateQuoted { get; set; }
        public DateTime? DateAccepted { get; set; }
    }
}
