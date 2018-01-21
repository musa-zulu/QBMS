using System;

namespace QBMS.Core.Domain
{
    public class Client : EntityBase
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public int TitleId { get; set; }
        public virtual Title Title { get; set; }
    }
}
