using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() => new()
    {
        new User()
        {
            Id = 1,
            Name = "niloy",
            Email = "niloy@niloy.com",
            Address = new()
            {
                Street = "Satirpara",
                City = "Narsingdi",
                ZipCode = "1600"
            }
        },
        new User()
        {
            Id = 2,
            Name = "zarin",
            Email = "zarin@niloy.com",
            Address = new()
            {
                Street = "Satirpara",
                City = "Narsingdi",
                ZipCode = "1600"
            }
        },
        new User()
        {
            Id = 3,
            Name = "nisa",
            Email = "nisa@nisa.com",
            Address = new()
            {
                Street = "Satirpara",
                City = "Narsingdi",
                ZipCode = "1600"
            }
        }
    };
}