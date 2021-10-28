using Hive.SeedWorks.TacticalPatterns;

namespace Domain.Abstraction
{
    /// <summary>
    /// Пакеты услуг, как объект-значение.
    /// </summary>
    public interface IPackagesOfService : IValueObject
    {
        IPackageOfService[] Packages { get; }
    }
}