using System.Text.RegularExpressions;

class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public User(string name, string surname, string password)
    {
        Name = name;
        Surname = surname;
        Password = password;
        GenerateEmail();
        GenerateUsername();
    }


    public void GenerateEmail()
    {
        Email = $"{Name.ToLower()}.{Surname.ToLower()}@gmail.com";
    }

    public void GenerateUsername()
    {
        Username = $"{Name.ToLower()}.{Surname.ToLower()}";
    }

    public bool VerifyPassword(string password)
    {
        return Password == password;
    }
}
