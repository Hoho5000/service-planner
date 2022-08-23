using ServicePlanner.Service.Output;

namespace ServicePlanner.Service.Models
{
    public interface ServiceItem
    {
        public string Format(ServiceItemFormatter formatter);
    }
}
