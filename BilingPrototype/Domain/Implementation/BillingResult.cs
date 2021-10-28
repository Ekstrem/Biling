using System.Collections.Generic;
using Hive.SeedWorks.Invariants;
using Hive.SeedWorks.Result;
using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Implementation
{
    internal class BillingResult : AggregateResult<IBilling>
    {
        private readonly DomainOperationResultEnum _result;
        private readonly IEnumerable<string> _reason;

        internal BillingResult(IAnemicModel<IBilling> oldVersion, IAnemicModel<IBilling> newVersion, DomainOperationResultEnum result, IEnumerable<string> reason)
            : base(MakeBusinessOperationData(oldVersion, newVersion))
        {
            _result = result;
            _reason = reason;
        }

        private static BusinessOperationData<IBilling> MakeBusinessOperationData(
            IAnemicModel<IBilling> oldVersion, IAnemicModel<IBilling> newVersion)
            => BusinessOperationData<IBilling>.Commit(oldVersion, newVersion);

        public override DomainOperationResultEnum Result => _result;

        public override IEnumerable<string> Reason => _reason;
    }
}