namespace DeshaDinner.Domain.User;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
   

    public User()
    {
        
    }
    public User(Guid id, string fname, string lname,
        string email, string password)
    {
        Id=id;
        FirstName=fname;
        LastName=lname;
        Email=email;
        Password=password;
     
    }
}
