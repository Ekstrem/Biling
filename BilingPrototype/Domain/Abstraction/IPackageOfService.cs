using System;

namespace Domain.Abstraction
{
    public interface ITariff
    {
        DateTime Duration { get; }
        long Limit { get; }
    }
    
    public interface IPackageOfService : ITariff
    {
        LicenseTypeEnum Type { get; }
        string LicenseId { get; }
        string RequestId { get; }
        string Status { get; }
        DateTime CreationDate { get; }
        DateTime ActivationDate { get; }
    }

    public interface ILicenseProlongation : IPackageOfService
    {
        string LicenseProlongationId { get; }
    }

    public interface ILicenseExtension : IPackageOfService
    {
        string LicenseILicenseExtensionId { get; }
    }

    public enum LicenseTypeEnum
    {
        Prolongation = 1,
        Extension = 2
    }
}