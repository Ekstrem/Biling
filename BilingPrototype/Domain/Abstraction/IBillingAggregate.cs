using Hive.SeedWorks.Characteristics;
using Hive.SeedWorks.Result;
using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Abstraction
{
    /// <summary>
    /// Агрегат билинга.
    /// </summary>
    public interface IBillingAggregate : 
        IAggregate<IBilling>,
        IBillingAnemicModel
    {
        /// <summary>
        /// Подписчик выбрал тариф по умолчанию.
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> SubscriberChoseDefaultTariff(IBillingAnemicModel model, ICommandToAggregate commandMetadata);
        
        /// <summary>
        /// Подписчик запросил новый пакет.
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> SubscriberRequestedNewPackage(IBillingAnemicModel model, ICommandToAggregate commandMetadata);
        
        /// <summary>
        /// Запрашиваемый пакет подтверждён.
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> RequestPackageAccepted(string requestId, ICommandToAggregate commandMetadata);
        
        /// <summary>
        /// Запрашиваемый пакет отклонён.
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> RequestPackageRejected(string requestId, ICommandToAggregate commandMetadata);
        
        /// <summary>
        /// Пакет(ы)\ активирован(ы).
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> ActivatePackage(IBillingAnemicModel model, ICommandToAggregate commandMetadata);
        
        /// <summary>
        /// Пакет завершил своё действие.
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> ExpiredPackage(IBillingAnemicModel model, ICommandToAggregate commandMetadata);
        
        /// <summary>
        /// Пользователь отправил документ.
        /// </summary>
        /// <param name="model">Данные команды.</param>
        /// <param name="commandMetadata">Метаданные команды.</param>
        /// <returns>Результат доменной операции.</returns>
        AggregateResult<IBilling> SendDocument(IBillingAnemicModel model, ICommandToAggregate commandMetadata);
        
        
    }
}