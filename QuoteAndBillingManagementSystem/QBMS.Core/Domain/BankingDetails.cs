namespace QBMS.Core.Domain
{
    public class BankingDetails : EntityBase
    {
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string BankBranchCode { get; set; }
    }
}
