using ServicePlanner.Service.Models;

namespace ServicePlanner.Service.Components.ServiceItems
{
    public class MoveEventInfo
    {
        public ServiceItem Item { get; set; }

        public MoveDirection Direction { get; set; }
    }
}
