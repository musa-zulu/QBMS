namespace QBMS.DB
{
    public class DataConstants
    {
        public const string DefaultConnectionName = "DefaultConnection";

        public class Tables
        {
            public class Title
            {
                public const string TableName = "Title";

                public class Columns
                {
                    public const string TitleId = "TitleId";
                    public const string Description = "Description";
                }
            }

            public class Client
            {
                public const string TableName = "Client";

                public class Columns
                {
                    public const string ClientId = "ClientId";
                    public const string TitleId = "TitleId";
                    public const string FirstName = "FirstName";
                    public const string Surname = "Surname";
                    public const string Email = "Email";
                    public const string ContactNumber = "ContactNumber";
                }
            }

            public class Quote
            {
                public const string TableName = "Quote";

                public class Columns
                {
                    public const string QuoteId = "QuoteId";
                    public const string Description = "Description";
                    public const string BillingAddress = "BillingAddress";
                    public const string CompanyId = "CompanyId";
                }
            }

            public class Roles
            {
                public const string TableName = "AspNetRoles";

                public class Columns
                {
                    public const string RolesId = "RolesId";
                    public const string Name = "Name";
                }
            }

            public class ClientsQuoteItem
            {
                public const string TableName = "ClientsQuoteItem";

                public class Columns
                {
                    public const string ClientsQuoteItemId = "ClientsQuoteItemId";
                    public const string ClientId = "ClientId";
                    public const string QuoteId = "QuoteId";
                    public const string DateQuoted = "DateQuoted";
                    public const string DateAccepted = "DateAccepted";
                }
            }

            public class Company
            {
                public const string TableName = "Company";

                public class Columns
                {
                    public const string CompanyId = "ComapnyId";
                    public const string TradingName = "TradingName";
                    public const string RegisteredName = "RegisteredName";
                    public const string RegistrationNumber = "RegistrationNumber";
                    public const string Cell = "Cell";
                    public const string Phone = "Phone";
                    public const string VatNumber = "VatNumber";
                    public const string EmailAddress = "EmailAddress";
                    public const string BankingDetailsId = "BankingDetailsId";
                    public const string AddressId = "AddressId";              
                }
            }

            public class Address
            {
                public const string TableName = "Address";

                public class Columns
                {
                    public const string AddressId = "AddressId";
                    public const string HouseNumber = "HouseNumber";
                    public const string StreetName = "StreetName";
                    public const string Suburb = "Suburb";
                    public const string City = "City";
                    public const string PostalCode = "PostalCode";
                    public const string CountryCode = "CountryCode";
                    public const string AddressType = "AddressType";
                }
            }

            public class BankingDetails
            {
                public const string TableName = "BankingDetails";

                public class Columns
                {
                    public const string BankingDetailsId = "BankingDetailsId";
                    public const string AccountNumber = "AccountNumber";
                    public const string BankName = "BankName";
                    public const string BankBranch = "BankBranch";
                    public const string BankBranchCode = "BankBranchCode";
                }
            }


            public class Invoice
            {
                public const string TableName = "Invoice";

                public class Columns
                {
                    public const string InvoiceId = "InvoiceId";
                    public const string InvoiceDate = "InvoiceDate";
                    public const string Description = "Description";
                    public const string QTY = "QTY";
                    public const string UnitPrice = "UnitPrice";
                    public const string Total = "Total";
                    public const string SubTotal = "SubTotal";
                    public const string Vat = "Vat";
                    public const string TotalDue = "TotalDue";
                    public const string OrderNumber = "OrderNumber";
                    public const string M_OR_S = "M_OR_S";
                    public const string CompanyId = "CompanyId";            
                }
            }
        }
    }
}