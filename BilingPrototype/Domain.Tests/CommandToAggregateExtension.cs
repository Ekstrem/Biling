using System;
using Hive.SeedWorks.Characteristics;
using Hive.SeedWorks.Events;

namespace Domain.Tests
{
    public static class CommandToAggregateExtension
    {
        public static ICommandToAggregate CreateCommandMetadata(this string commandName)
            => CommandToAggregate.Commit(
                Guid.NewGuid(),
                commandName,
                "test",
                DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }
}