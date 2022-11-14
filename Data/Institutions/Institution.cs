using ServicePlanner.Data;

public class Institution
{
    public Guid Id { get; set; }

    public string Name { get; set; } = "";

    public PhoneNumber Phone { get; set; } = new PhoneNumber();

    public Address Address { get; set; } = new Address();
}
