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
        }
    }
}