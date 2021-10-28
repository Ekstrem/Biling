using System;
using System.Collections.Generic;
using Domain.Abstraction;
using Hive.SeedWorks.Characteristics;
using Hive.SeedWorks.LifeCircle;
using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Implementation
{
    public class AnemicModel : IBillingAnemicModel
    {
        private readonly Guid _id;
        private readonly long _version;
        private readonly string _commandName;
        private readonly string _subjectName;
        private readonly Guid _correlationToken;
        private readonly IBillingRoot _root;
        private readonly IRequestedPackages _requestedPackages;
        private readonly IAcceptedPackages _acceptedPackages;
        private readonly IRejectedPackages _rejectedPackages;
        private readonly IActivePackages _activePackages;
        private readonly IExpiredPackages _expiredPackages;
        private readonly ILastSendedDocument _lastSendedDocument;
        private readonly IComputedLimit _computedLimit;

        protected AnemicModel(
            Guid id,
            long version,
            Guid correlationToken,
            string commandName,
            string subjectName,
            IBillingRoot root,
            IRequestedPackages requestedPackages,
            IAcceptedPackages acceptedPackages,
            IRejectedPackages rejectedPackages,
            IActivePackages activePackages,
            IExpiredPackages expiredPackages,
            ILastSendedDocument lastSendedDocument,
            IComputedLimit computedLimit)
        {
            _id = id;
            _version = version;
            _correlationToken = correlationToken;
            _commandName = commandName;
            _subjectName = subjectName;
            _root = root;
            _requestedPackages = requestedPackages;
            _acceptedPackages = acceptedPackages;
            _rejectedPackages = rejectedPackages;
            _activePackages = activePackages;
            _expiredPackages = expiredPackages;
            _lastSendedDocument = lastSendedDocument;
            _computedLimit = computedLimit;
        }

        public Guid Id => _id;

        public long Version => _version;

        public string CommandName => _commandName;

        public string SubjectName => _subjectName;

        public Guid CorrelationToken => _correlationToken;

        public IDictionary<string, IValueObject> GetValueObjects()
            => ValueObjectHelper.GetValueObjects(this);

        public IBillingRoot Root => _root;

        public IRequestedPackages RequestedPackages => _requestedPackages;

        public IAcceptedPackages AcceptedPackages => _acceptedPackages;

        public IRejectedPackages RejectedPackages => _rejectedPackages;

        public IActivePackages ActivePackages => _activePackages;

        public IExpiredPackages ExpiredPackages => _expiredPackages;

        public ILastSendedDocument LastSendedDocument => _lastSendedDocument;

        public IComputedLimit ComputedLimit => _computedLimit;
        
        public static IBillingAnemicModel Create(
            Guid id,
            long version,
            Guid correlationToken,
            string commandName,
            string subjectName,
            IBillingRoot root,
            IRequestedPackages requestedPackages,
            IAcceptedPackages acceptedPackages,
            IRejectedPackages rejectedPackages,
            IActivePackages activePackages,
            IExpiredPackages expiredPackages,
            ILastSendedDocument lastSendedDocument,
            IComputedLimit computedLimit)
            => new AnemicModel(id, version,
                correlationToken, commandName, subjectName,
                root, requestedPackages, acceptedPackages, rejectedPackages,
                activePackages, expiredPackages,
                lastSendedDocument, computedLimit);
        
        public static IBillingAnemicModel Create(
            Guid id,
            ICommandToAggregate command,
            IBillingRoot root,
            IRequestedPackages requestedPackages,
            IAcceptedPackages acceptedPackages,
            IRejectedPackages rejectedPackages,
            IActivePackages activePackages,
            IExpiredPackages expiredPackages,
            ILastSendedDocument lastSendedDocument,
            IComputedLimit computedLimit)
            => new AnemicModel(id, 
                command.Version, command.CorrelationToken, command.CommandName, command.SubjectName,
                root, requestedPackages, acceptedPackages, rejectedPackages,
                activePackages, expiredPackages,
                lastSendedDocument, computedLimit);
    }
}