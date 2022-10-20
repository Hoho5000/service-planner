using ServicePlanner.Data.Service;

namespace ServicePlanner.Service.Wizard.OrderOfService
{
    public class MoveEventInfo
    {
        public ServiceItem Item { get; set; }

        public MoveDirection Direction { get; set; }
    }
}
