namespace ClassEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Lisa" , 2);
            cat.Breed = "British";
            cat.getInfo();

            Snake snake = new Snake("Dora" , 9);
            snake.Breed = "Cobra";
            snake.Poison = true;
            snake.getInfoSnake();

            Dog dog = new Dog("Rex", -9);
            dog.Breed = "Rockefeller";
            dog.getInfo();

            Dolphin dolphin = new Dolphin("Larisa", 2);
            dolphin.Breed = "ssadas";
            dolphin.getInfo();
        }
    }
}