namespace ServicePlanner.Data
{
    public class PhoneNumber
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = "";

        public override string ToString()
        {
            return Number;
        }
    }
}
