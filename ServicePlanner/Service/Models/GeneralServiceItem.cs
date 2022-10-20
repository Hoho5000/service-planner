using ServicePlanner.Service.Output;

namespace ServicePlanner.Service.Models
{
    public class GeneralServiceItem : ServiceItem
    {
        public string Content { get; set; }

        public string Format(BasicServiceItemFormatter formatter)
        {
            return formatter.FormatServiceItem(this);
        }
    }
}
