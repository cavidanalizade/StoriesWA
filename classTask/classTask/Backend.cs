using System;


namespace classTask
{
    internal class Backend:Developer
    {
        public byte SqlExperienceYear;

        public Backend(string Name , string Surname , byte Experience)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Experience = Experience;
        }

       public void printUsertoConsole()
        {
            Console.WriteLine($"My name is {Name} {Surname} I have {Experience} years experience as a backend dev");
        }
    }
}
