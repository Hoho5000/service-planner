namespace ServicePlanner.Service.Models
{
    public class GeneralServiceItem : ServiceItem
    {
        public string Content { get; set; }

        public string Format(ServiceItemFormatter formatter)
        {
            return formatter.FormatServiceItem(this);
        }
    }
}
