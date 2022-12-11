
namespace dotnet_demo.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; } = null!;
    public long Mobile { get; set; }
    public string ProfileImageUrl { get; set; } = null!;
    public Guid GenderId { get; set; }

    public Gender Gender { get; set; } = null!;
    public Address Address { get; set; } = null!;

}