using System;
using Domain.Abstraction;

namespace Domain.Implementation
{
    public class ComputedLimit : IComputedLimit
    {
        private ComputedLimit(long limit, DateTime duration)
        {
            Limit = limit;
            Duration = duration;
        }

        public DateTime Duration { get; }
        public long Limit { get; }

        public static ComputedLimit CreateInstance(long limit, DateTime duration) => new ComputedLimit(limit, duration);
    }
}