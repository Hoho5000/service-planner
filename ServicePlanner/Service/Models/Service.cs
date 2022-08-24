namespace ServicePlanner.Service.Models
{
    public class Service
    {
        public DateTime Date { get; set; }

        public List<ServiceItem> Items { get; set; } = new List<ServiceItem>();
    }
}
