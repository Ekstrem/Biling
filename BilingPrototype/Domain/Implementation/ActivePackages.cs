using Domain.Abstraction;

namespace Domain.Implementation
{
    public class ActivePackages : IActivePackages
    {
        private ActivePackages(IPackageOfService[] packages) => Packages = packages;

        public IPackageOfService[] Packages { get; }

        public static ActivePackages CreateInstance(IPackageOfService[] packages) => new ActivePackages(packages);
    }
}