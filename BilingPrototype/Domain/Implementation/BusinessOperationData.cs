using Domain.Abstraction;
using Hive.SeedWorks.Invariants;

namespace Domain.Implementation
{
    internal sealed class BusinessOperationData : BusinessOperationData<IBilling, IBillingAnemicModel>
    {
        private BusinessOperationData(IBillingAnemicModel aggregate, IBillingAnemicModel model)
            : base(aggregate, model)
        {
        }

        public static BusinessOperationData Commit(IBillingAnemicModel aggregate, IBillingAnemicModel model)
            => new BusinessOperationData(aggregate, model);
    }
}