using System.Text.RegularExpressions;

class Company
{
    public string Name { get; set; }
    private User[] users = new User[100]; 
    private int userCount = 0;
    
    public void Register(string name, string surname, string password)
    {
         bool IsValidPassword(string password)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        if (!IsValidPassword(password))
        {
            Console.WriteLine("password must be minimum 8 character and min one upper one lower and one number  .");
            return;
        }

        User newUser = new User(name, surname, password);
        if (userCount < users.Length)
        {
            users[userCount] = newUser;
            userCount++;
            Console.WriteLine($"User {newUser.Username} registered with email {newUser.Email}");
        }
        else
        {
            Console.WriteLine("User limit reached. Cannot register more users.");
        }
    }

    public void Login(string username, string password)
    {
        bool userFound = false;

        foreach (User user in users)
        {
            if (user != null && user.Username == username)
            {
                if (user.VerifyPassword(password))
                {
                    Console.WriteLine($"User {user.Username} logged in.");
                }
                else
                {
                    Console.WriteLine("Username or password is incorrect.");
                }
                userFound = true;
                break;
            }
        }

        if (!userFound)
        {
            Console.WriteLine("Username or password is incorrect.");
        }
    }

    public void GetAll()
    {
        Console.WriteLine("Users in the company:");
        foreach (User user in users)
        {
            if (user != null)
            {
                Console.WriteLine($"{user.Name} {user.Surname} ({user.Username}, {user.Email})");
            }
        }
    }

    public User GetByUsername(string username)
    {
        foreach (User user in users)
        {
            if (user != null && user.Username == username)
            {
                return user;
            }
        }
        return null;
    }

    public void UpdateByUsername(string username, string updatedValue, char choice)
    {
        foreach (User user in users)
        {
            if (user != null && user.Username == username)
            {
                switch (choice)
                {
                    case 'a':
                        user.Name = updatedValue;
                        user.GenerateEmail();
                        user.GenerateUsername();
                        break;
                    case 'b':
                        user.Surname = updatedValue;
                        user.GenerateEmail();
                        user.GenerateUsername();
                        break;
                    case 'c':
                        user.Username = updatedValue;
                        break;
                    case 'd':
                        Console.WriteLine("Email cannot be updated directly.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }
                Console.WriteLine("User data updated successfully.");
                return;
            }
        }

        Console.WriteLine("User not found.");
    }

    public void DeleteByUsername(string username)
    {
        for (int i =0; i<userCount;i++)
        {
            if (users[i] != null && users[i].Username == username)
            {
                Console.WriteLine($"User {username} deleted from the company.");
                users[i] = null;
                return;
            }
        }
        Console.WriteLine("User not found.");
    }
}
