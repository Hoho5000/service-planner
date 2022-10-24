

using System.ComponentModel.DataAnnotations.Schema;

namespace ServicePlanner.Data.Service
{
    [Table("GeneralServiceItems")]
    public class GeneralServiceItem : ServiceItem
    {
        public string Content { get; set; } = "";

        public override string Format(ServiceItemFormatter formatter)
        {
            return formatter.FormatServiceItem(this);
        }
    }
}
