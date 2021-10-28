using Hive.SeedWorks.Invariants;
using Hive.SeedWorks.Result;

namespace Domain.Specifications
{
    /// <summary>
    /// Поверяет что данные транслированные ACL соответствует началу биллинка подписчика.
    /// </summary>
    public class IsTranslatedEnteringTariffCorrectValidator : IBusinessOperationValidator<IBilling>
    {
        public bool IsSatisfiedBy(BusinessOperationData<IBilling> obj)
        {
            throw new System.NotImplementedException();
        }

        public string Reason => "Транслированная модель не соответствует тарифу по умолчанию.";

        public DomainOperationResultEnum DomainResult => DomainOperationResultEnum.Exception;
    }
}