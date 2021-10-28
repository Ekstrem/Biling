using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Abstraction
{
    /// <summary>
    /// Подсчитанный текущий лимит действия лицензии.
    /// </summary>
    public interface IComputedLimit : ITariff, IValueObject { }
}