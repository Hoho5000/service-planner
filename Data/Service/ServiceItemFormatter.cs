using ServicePlanner.Data.Music;

namespace ServicePlanner.Data.Service
{
    public interface ServiceItemFormatter
    {
        string FormatServiceItem(GeneralServiceItem item);

        string FormatServiceItem(Song song);
    }
}