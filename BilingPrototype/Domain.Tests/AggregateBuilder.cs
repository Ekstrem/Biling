using System;
using Domain.Abstraction;
using Domain.Implementation;
using Hive.SeedWorks.Monads;

namespace Domain.Tests
{
    public static class AggregateBuilder
    {
        public static IBillingAnemicModel CreatePureModelForNewBilling(Guid id)
            => AnemicModel
                .Create(
                    id,
                    nameof(Aggregate.SubscriberChoseDefaultTariff).CreateCommandMetadata(), 
                    default,
                    default,
                    default,
                    default,
                    PackageBuilder
                        .DefaultTariff()
                        .PipeTo(p => new IPackageOfService[] { p })
                        .PipeTo(ActivePackages.Create),
                    default,
                    default,
                    default);
    }
}