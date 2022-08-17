using ServicePlanner.Service;
using ServicePlanner.Service.Models;

namespace ServicePlanner.Data.Music
{
    public class Song : ServiceItem
    {
        public int Number { get; set; }

        public string Title { get; set; }

        public string Format(ServiceItemFormatter formatter)
        {
            return formatter.FormatServiceItem(this);
        }
    }
}
