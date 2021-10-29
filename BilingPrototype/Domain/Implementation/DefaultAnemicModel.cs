using System;
using Domain.Abstraction;

namespace Domain.Implementation
{
    public sealed class DefaultAnemicModel : AnemicModel
    {
        private DefaultAnemicModel(Guid id)
            : base(id, default, default, default, default,
                default, default, default, default, default,
                default, default, default)
        { }

        public static IBillingAnemicModel Create(Guid id) => new DefaultAnemicModel(id);
    }
}