namespace QBMS.Core.Domain
{
    public class Company : EntityBase
    {        
        public string TradingName { get; set; }
        public string RegisteredName { get; set; }
        public string RegistrationNumber { get; set; }
        public long Cell { get; set; }
        public long Phone { get; set; }
        public string VatNumber { get; set; }
        public string EmailAddress { get; set; }
        public int BankingDetailsId { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual BankingDetails BankingDetails { get; set; }
    }
}
