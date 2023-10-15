using System;



class Program
{
    static void Main(string[] args)
    {
        Company company = new Company();
        company.Name = "MyCompany";

        int choice;

        do
        {
            Console.WriteLine("\nCompany Management Menu:");
            Console.WriteLine("1. Register a user");
            Console.WriteLine("2. Login a user");
            Console.WriteLine("3. See all users in the company");
            Console.WriteLine("4. Get one user by username");
            Console.WriteLine("5. Update user's data");
            Console.WriteLine("6. Delete user from company");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Nsme: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string password = Console.ReadLine();
                        company.Register(name, surname, password);
                        break;
                    case 2:
                        Console.Write("Enter Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        string loginPassword = Console.ReadLine();
                        company.Login(username, loginPassword);
                        break;
                    case 3:
                        company.GetAll();
                        break;
                    case 4:
                        Console.Write("Enter Username: ");
                        string getByUsername = Console.ReadLine();
                        User user = company.GetByUsername(getByUsername);
                        if (user != null)
                        {
                            Console.WriteLine($"{user.Name} {user.Surname} ({user.Username}, {user.Email})");
                        }
                        else
                        {
                            Console.WriteLine("User not found.");
                        }
                        break;
                    case 5:
                        Console.Write("Enter Username: ");
                        string updateUsername = Console.ReadLine();
                        Console.WriteLine("Choose what to update:");
                        Console.WriteLine("a. Update name");
                        Console.WriteLine("b. Update surname");
                        Console.WriteLine("c. Update username");
                        Console.WriteLine("d. Update email");
                        Console.Write("Enter your choice: ");
                        char updateChoice = Console.ReadKey().KeyChar;
                        Console.WriteLine(); 
                        Console.Write("Enter the updated value: ");
                        string updatedValue = Console.ReadLine();
                        company.UpdateByUsername(updateUsername, updatedValue, updateChoice);
                        break;
                    case 6:
                        Console.Write("Enter Username: ");
                        string deleteUsername = Console.ReadLine();
                        company.DeleteByUsername(deleteUsername);
                        break;
                    case 7:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        } while (choice != 7);
    }
}
