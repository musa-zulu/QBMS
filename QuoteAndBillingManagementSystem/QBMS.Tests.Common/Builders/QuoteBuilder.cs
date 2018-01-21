using QBMS.Core.Domain;
using PeanutButter.RandomGenerators;

namespace QBMS.Tests.Common.Builders
{
    public class QuoteBuilder : GenericBuilder<QuoteBuilder, Quote>
    {
        private int _companyId;
        private bool _isNew;
        public QuoteBuilder AsNewClient()
        {
            _isNew = true;
            return this;
        }
        public QuoteBuilder WithValidCompanyId()
        {
            _companyId = RandomValueGen.GetRandomInt(1, 7);
            return this;
        }

        public override Quote Build()
        {
            if (_isNew) this.WithProp(quote => quote.Id = 0);
            this.WithProp(quote => quote.CompanyId = _companyId);
            return base.Build();
        }

        public QuoteBuilder WithNewId()
        {
            this.WithProp(quote => quote.Id = 0);
            return this;
        }
        public QuoteBuilder WithValidExistingId()
        {
            this.WithProp(quote => quote.Id = RandomValueGen.GetRandomInt(1, 1000));
            return this;
        }
    }
}