using System;

namespace Domain.Implementation
{
    public class DefaultAnemicModel : AnemicModel
    {
        protected DefaultAnemicModel(Guid id)
            : base(id, default, default, default, default,
                default, default, default, default, default,
                default, default, default)
        {
        }
    }
}