using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstraction;
using Domain.Specifications;
using Hive.SeedWorks.Characteristics;
using Hive.SeedWorks.Invariants;
using Hive.SeedWorks.Monads;
using Hive.SeedWorks.Result;
using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Implementation
{
    public class Aggregate : IBillingAggregate
    {
        private readonly IBillingAnemicModel _anemicModel;

        private Aggregate(IBillingAnemicModel anemicModel) => _anemicModel = anemicModel;

        #region Aggregate tech  props

        public Guid Id => _anemicModel.Id;

        public long Version => _anemicModel.Version;

        public string CommandName => _anemicModel.CommandName;

        public string SubjectName => _anemicModel.SubjectName;

        public Guid CorrelationToken => _anemicModel.CorrelationToken;

        public IDictionary<string, IValueObject> GetValueObjects()
            => _anemicModel.GetValueObjects();

        #endregion

        #region AnemicModel

        public IBillingRoot Root => _anemicModel.Root;

        public IRequestedPackages RequestedPackages => _anemicModel.RequestedPackages;

        public IAcceptedPackages AcceptedPackages => _anemicModel.AcceptedPackages;

        public IRejectedPackages RejectedPackages => _anemicModel.RejectedPackages;

        public IActivePackages ActivePackages => _anemicModel.ActivePackages;

        public IExpiredPackages ExpiredPackages => _anemicModel.ExpiredPackages;

        public ILastSendedDocument LastSendedDocument => _anemicModel.LastSendedDocument;

        public IComputedLimit ComputedLimit => _anemicModel.ComputedLimit;
        
        #endregion

        public AggregateResult<IBilling> SubscriberChoseDefaultTariff(IBillingAnemicModel model,
            ICommandToAggregate commandMetadata)
            => BusinessOperationData<IBilling>
                .Commit(_anemicModel, model)
                .ValidateCommand(
                    new IsNewSubscriberBillingValidator(),
                    new IsTranslatedEnteringTariffCorrectValidator());

        public AggregateResult<IBilling> SubscriberRequestedNewPackage(IBillingAnemicModel model, ICommandToAggregate commandMetadata)
        {
            throw new NotImplementedException();
        }

        public AggregateResult<IBilling> RequestPackageAccepted(string requestId, ICommandToAggregate commandMetadata)
        {
            if (RequestedPackages.Packages.All(f => f.RequestId != requestId))
            {
                return new BillingResult(
                    _anemicModel,
                    null,
                    DomainOperationResultEnum.Exception,
                    new []{ $"В списке ожидающих запросов, не найден запрос {requestId}" });
            }

            var requestedPackages = RequestedPackages.Packages
                .Where(f => f.RequestId != requestId)
                .ToArray()
                .PipeTo(arr => new RequestedPackages(arr));
            var package = RequestedPackages.Packages.Single(f => f.RequestId == requestId);
            var acceptedPackages = AcceptedPackages.Packages
                .ToList()
                .Do(ap => ap.Add(package))
                .ToArray()
                .PipeTo(arr => new AcceptedPackages(arr));
            return AnemicModel
                .Create(
                    _anemicModel.Id, commandMetadata,
                    _anemicModel.Root, requestedPackages, acceptedPackages, _anemicModel.RejectedPackages,
                    _anemicModel.ActivePackages, _anemicModel.ExpiredPackages,
                    _anemicModel.LastSendedDocument, _anemicModel.ComputedLimit)
                .PipeTo(am => new BillingResult(_anemicModel, am, DomainOperationResultEnum.Success, default));
        }

        public AggregateResult<IBilling> RequestPackageRejected(string requestId, ICommandToAggregate commandMetadata)
        {
            throw new NotImplementedException();
        }

        public AggregateResult<IBilling> ActivatePackage(IBillingAnemicModel model, ICommandToAggregate commandMetadata)
        {
            throw new NotImplementedException();
        }

        public AggregateResult<IBilling> ExpiredPackage(IBillingAnemicModel model, ICommandToAggregate commandMetadata)
        {
            throw new NotImplementedException();
        }

        public AggregateResult<IBilling> SendDocument(IBillingAnemicModel model, ICommandToAggregate commandMetadata)
        {
            throw new NotImplementedException();
        }
    }
}