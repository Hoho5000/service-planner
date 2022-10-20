using ServicePlanner.Data.Music;
using ServicePlanner.Service.Models;

namespace ServicePlanner.Service.Output
{
    public interface ServiceItemFormatter
    {
        string FormatServiceItem(GeneralServiceItem item);
        string FormatServiceItem(Song song);
    }
}