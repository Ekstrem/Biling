using System;
using Domain.Abstraction;
using Domain.Implementation;

namespace Domain.Tests
{
    public static class PackageBuilder
    {
        public static IPackageOfService DefaultTariff()
        {
            return new PackageOfService
            {
                Duration = DateTime.Today,
                Limit = 5,
                Type = LicenseTypeEnum.Prolongation,
                LicenseId = null,
                RequestId = null,
                Status = "Active",
                CreationDate = DateTime.Today
            };
        }
    }
}