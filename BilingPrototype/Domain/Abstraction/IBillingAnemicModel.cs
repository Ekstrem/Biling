using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Abstraction
{
    /// <summary>
    /// Анемичная модель агрегата.
    /// </summary>
    public interface IBillingAnemicModel : IAnemicModel<IBilling>
    {
        /// <summary>
        /// Корень агрегата.
        /// </summary>
        IBillingRoot Root { get; }
        
        /// <summary>
        /// Запрошенные пакеты.
        /// </summary>
        IRequestedPackages RequestedPackages { get; }
        
        /// <summary>
        /// Одобренные пакеты, поставленные в очередь.
        /// </summary>
        IAcceptedPackages AcceptedPackages { get; }
        
        /// <summary>
        /// Пакеты, заявка по которым была отклонена.
        /// </summary>
        IRejectedPackages RejectedPackages { get; }
        
        /// <summary>
        /// Активные пакеты.
        /// </summary>
        IActivePackages ActivePackages { get; }
        
        /// <summary>
        /// Истёкшие пакеты.
        /// </summary>
        IExpiredPackages ExpiredPackages { get; }
        
        /// <summary>
        /// Последний отправленный документ.
        /// </summary>
        ILastSendedDocument LastSendedDocument { get; }
        
        /// <summary>
        /// Высчитанный остаток по пакетам.
        /// </summary>
        IComputedLimit ComputedLimit { get; }
    }
}