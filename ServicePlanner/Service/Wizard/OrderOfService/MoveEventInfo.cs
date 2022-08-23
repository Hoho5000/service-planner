using ServicePlanner.Service.Models;

namespace ServicePlanner.Service.Wizard.OrderOfService
{
    public class MoveEventInfo
    {
        public ServiceItem Item { get; set; }

        public MoveDirection Direction { get; set; }
    }
}
