using Domain.Abstraction;

namespace Domain.Implementation
{
    public class RejectedPackages : IRejectedPackages
    {
        private RejectedPackages(IPackageOfService[] packages) => Packages = packages;

        public IPackageOfService[] Packages { get; }

        public static RejectedPackages CreateInstance(IPackageOfService[] packages) => new RejectedPackages(packages);
    }
}