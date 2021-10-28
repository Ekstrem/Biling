using Domain.Implementation;
using Hive.SeedWorks.Invariants;
using Hive.SeedWorks.Result;

namespace Domain.Specifications
{
    /// <summary>
    /// Валидатор проверяющий, что сущность новая.
    /// </summary>
    public class IsNewSubscriberBillingValidator : IBusinessOperationValidator<IBilling>
    {
        public bool IsSatisfiedBy(BusinessOperationData<IBilling> obj)
            => obj.Aggregate is DefaultAnemicModel;

        public string Reason => "Операция применима только для новых сущностей.";

        public DomainOperationResultEnum DomainResult => DomainOperationResultEnum.Exception;
    }
}