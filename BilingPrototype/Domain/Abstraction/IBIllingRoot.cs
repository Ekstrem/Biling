using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Abstraction
{
    /// <summary>
    /// Корень. Отражает абонента.
    /// </summary>
    public interface IBillingRoot : IAggregateRoot<IBilling>
    {
        /// <summary>
        /// Идентификатор абонента.
        /// </summary>
        string AbonentId { get; }
        
        /// <summary>
        /// Партнёрский код.
        /// </summary>
        string PartnerCode { get; }
    }
}