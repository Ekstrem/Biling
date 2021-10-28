using Domain.Abstraction;

namespace Domain.Implementation
{
    public class ExpiredPackages : IExpiredPackages
    {
        private ExpiredPackages(IPackageOfService[] packages) => Packages = packages;

        public IPackageOfService[] Packages { get; }

        public static ExpiredPackages CreateInstance(IPackageOfService[] packages) => new ExpiredPackages(packages);
    }
}