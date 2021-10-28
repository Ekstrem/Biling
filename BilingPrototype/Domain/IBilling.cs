using Hive.SeedWorks.Definition;

namespace Domain
{
    /// <summary>
    /// Ограниченный контекст билинга.
    /// </summary>
    public interface IBilling : IBoundedContext { }
    
    public class BillingBoundedContextDescription : IBoundedContextDescription
    {
        public string ContextName => "Biling";

        public int MicroserviceVersion => 1;
    }
}