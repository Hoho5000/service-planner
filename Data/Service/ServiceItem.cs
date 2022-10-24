namespace ServicePlanner.Data.Service
{
    public abstract class ServiceItem
    {
        public Guid Id { get; set; }

        public abstract string Format(ServiceItemFormatter formatter);
    }
}
