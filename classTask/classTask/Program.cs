namespace classTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backend dev = new Backend(Name:"Javidan", Surname:"Alizada" , Experience:5 );
            Backend dev1 = new Backend(Name: "Murad", Surname: "Aliyev", Experience: 3) ;
            dev1.SqlExperienceYear = 2;

            dev.printUsertoConsole();
            dev1.printUsertoConsole();

            Frontend dev2 = new Frontend();
            Frontend dev3 = new Frontend();


        }
    }
}