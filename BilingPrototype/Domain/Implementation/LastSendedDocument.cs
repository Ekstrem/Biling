using System;
using Domain.Abstraction;

namespace Domain.Implementation
{
    public class LastSendedDocument : ILastSendedDocument
    {
        private LastSendedDocument(Guid documentId, DateTimeOffset sentDate)
        {
            DocumentId = documentId;
            SentDate = sentDate;
        }

        public Guid DocumentId { get; }

        public DateTimeOffset SentDate { get; }

        public static LastSendedDocument CreateInstance(Guid documentId, DateTimeOffset sentDate)
            => new LastSendedDocument(documentId, sentDate);
    }
}