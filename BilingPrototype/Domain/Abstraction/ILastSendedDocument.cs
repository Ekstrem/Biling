using System;
using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Abstraction
{
    /// <summary>
    /// Последний отправленный документ.
    /// </summary>
    public interface ILastSendedDocument : IValueObject
    {
        Guid DocumentId { get; }

        /// <summary>
        /// Дата отправки
        /// </summary>
        DateTimeOffset SentDate { get; }
    }
}