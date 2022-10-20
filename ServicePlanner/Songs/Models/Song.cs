using ServicePlanner.Service.Models;
using ServicePlanner.Service.Output;

namespace ServicePlanner.Data.Music
{
    public class Song : ServiceItem
    {
        public int Number { get; set; }

        public string Title { get; set; }

        public string Format(BasicServiceItemFormatter formatter)
        {
            return formatter.FormatServiceItem(this);
        }
    }
}
