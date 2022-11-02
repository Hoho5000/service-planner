using Microsoft.EntityFrameworkCore;

namespace ServicePlanner.Data.Service
{
    public class Service
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public List<ServiceItem> Items { get; set; } = new List<ServiceItem>();
    }
}
