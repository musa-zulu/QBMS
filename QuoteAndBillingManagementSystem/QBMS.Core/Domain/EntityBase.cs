using System;

namespace QBMS.Core.Domain
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public bool IsNew()
        {
            if (Id == Guid.Empty)
            {
                throw new InvalidOperationException("Id cannot be empty guid");
            }
            return Id == default(Guid);
        }
    }
}