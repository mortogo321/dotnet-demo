namespace dotnet_demo.Models;

public class Address
{
    public Guid Id { get; set; }
    public string PhysicalAddress { get; set; } = null!;
    public string PostalAddress { get; set; } = null!;

    public Guid StudentId { get; set; }
}