using System;
using Domain.Abstraction;

namespace Domain.Implementation
{
    public class PackageOfService : IPackageOfService
    {
        public DateTime Duration { get; set; }
        public long Limit { get; set; }
        public LicenseTypeEnum Type { get; set; }
        public string LicenseId { get; set; }
        public string RequestId { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ActivationDate { get; }
    }
}