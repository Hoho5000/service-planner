public class Address
{
    public Guid Id { get; set; }

    public string StreetAddress { get; set; } = "";

    public string City { get; set; } = "";

    public string Region { get; set; } = "";

    public int PostalCode { get; set; }

    public string Country { get; set; } = "";
}