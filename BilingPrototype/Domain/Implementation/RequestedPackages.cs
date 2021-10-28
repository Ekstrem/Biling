using Domain.Abstraction;

namespace Domain.Implementation
{
    public class RequestedPackages : IRequestedPackages
    {
        private readonly IPackageOfService[] _packages;

        internal RequestedPackages(IPackageOfService[] packages) => _packages = packages;

        public IPackageOfService[] Packages => _packages;

        public static IRequestedPackages Create(IPackageOfService[] packages) => new RequestedPackages(packages);
    }
}