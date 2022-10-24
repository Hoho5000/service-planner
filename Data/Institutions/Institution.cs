public class Institution
{
    public Guid Id { get; set; }

    public string Name { get; set; } = "";

    public string Phone { get; set; } = "";

    public Address Address { get; set; } = new Address();
}
