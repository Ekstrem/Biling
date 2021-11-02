using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Domain.Abstraction;
using Hive.SeedWorks.TacticalPatterns;

namespace DomainServices
{
    public class AggregateProvider : IAggregateProvider<IBilling, IBillingAnemicModel>
    {
        private readonly IBillingAggregateRepository _repository;

        public AggregateProvider(IBillingAggregateRepository repository) => _repository = repository;

        public IBillingAnemicModel GetAggregate(Guid id, long version)
            => _repository
                .GetByIdAndVersion(id, version, default)
                .GetAwaiter()
                .GetResult();

        public Task<IBillingAnemicModel> GetAggregateAsync(Guid id, long version, CancellationToken cancellationToken)
            => _repository.GetByIdAndVersion(id, version, cancellationToken);

        public IBillingAnemicModel GetAggregate(Guid id)
        {
            throw new NotImplementedException();
        }

        public IBillingAnemicModel GetAggregateAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}