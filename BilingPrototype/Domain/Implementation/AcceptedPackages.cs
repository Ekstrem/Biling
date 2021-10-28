using Domain.Abstraction;

namespace Domain.Implementation
{
    public class AcceptedPackages : IAcceptedPackages
    {
        internal AcceptedPackages(IPackageOfService[] packages) => Packages = packages;

        public IPackageOfService[] Packages { get; }

        public static IAcceptedPackages Create(IPackageOfService[] packages) => new AcceptedPackages(packages);
    }
}