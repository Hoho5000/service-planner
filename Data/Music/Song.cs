using ServicePlanner.Data.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicePlanner.Data.Music
{
    [Table("Songs")]
    public class Song : ServiceItem
    {
        public int Number { get; set; }

        public string Title { get; set; } = "";

        public override string Format(ServiceItemFormatter formatter)
        {
            return formatter.FormatServiceItem(this);
        }
    }
}
