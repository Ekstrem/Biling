using Domain.Abstraction;
using Hive.SeedWorks.Invariants;
using Hive.SeedWorks.Result;

namespace Domain.Specifications
{
    /// <summary>
    /// Поверяет что данные транслированные ACL соответствует началу биллинка подписчика.
    /// </summary>
    public class IsTranslatedEnteringTariffCorrectValidator : IBusinessOperationValidator<IBilling, IBillingAnemicModel>
    {
        public bool IsSatisfiedBy(BusinessOperationData<IBilling, IBillingAnemicModel> obj)
            => obj.Model.ActivePackages != null;

        public string Reason => "Транслированная модель не соответствует тарифу по умолчанию.";

        public DomainOperationResultEnum DomainResult => DomainOperationResultEnum.Exception;
    }
}