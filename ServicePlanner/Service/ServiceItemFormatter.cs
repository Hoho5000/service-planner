using ServicePlanner.Data.Music;
using ServicePlanner.Service.Models;

namespace ServicePlanner.Service
{
    public class ServiceItemFormatter
    {
        public string FormatServiceItem(Song song)
        {
            return $"{song.Number} - {song.Title}";
        }

        public string FormatServiceItem(GeneralServiceItem item)
        {
            return item.Content;
        }
    }
}
