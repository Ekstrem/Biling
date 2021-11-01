using System;
using Domain.Implementation;
using Hive.SeedWorks.Monads;
using Hive.SeedWorks.Result;
using Xunit;

namespace Domain.Tests
{
    public class AggregateTest
    {
        [Fact]
        public void NewAggregate()
        {
            var aggregateId = Guid.NewGuid();
            var pureModel = AggregateBuilder.CreatePureModelForNewBilling(aggregateId);
            var result = DefaultAnemicModel
                .Create(pureModel.Id)
                .PipeTo(Aggregate.Create)
                .SubscriberChoseDefaultTariff(pureModel);
            Assert.Equal(DomainOperationResultEnum.Success, result.Result);
        }
    }
}