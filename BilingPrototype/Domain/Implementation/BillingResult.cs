using System.Collections.Generic;
using Domain.Abstraction;
using Hive.SeedWorks.Invariants;
using Hive.SeedWorks.Result;
using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Implementation
{
    internal class BillingResult : AggregateResult<IBilling, IBillingAnemicModel>
    {
        private readonly DomainOperationResultEnum _result;
        private readonly IEnumerable<string> _reason;

        internal BillingResult(
            IBillingAnemicModel oldVersion,
            IBillingAnemicModel newVersion,
            DomainOperationResultEnum result,
            IEnumerable<string> reason)
            : base(MakeBusinessOperationData(oldVersion, newVersion))
        {
            _result = result;
            _reason = reason;
        }

        private static BusinessOperationData<IBilling, IBillingAnemicModel> MakeBusinessOperationData(
            IBillingAnemicModel oldVersion, IBillingAnemicModel newVersion)
            => BusinessOperationData<IBilling, IBillingAnemicModel>
                .Commit<IBilling, IBillingAnemicModel>(oldVersion, newVersion);

        public override DomainOperationResultEnum Result => _result;

        public override IEnumerable<string> Reason => _reason;
    }
}