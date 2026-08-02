namespace GameLuxcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как звоут героя?");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько тебе лет?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Твое звание: воин, лучник, маг, житель");
            string classHero = Console.ReadLine();

            Console.WriteLine("Какова твоя сила?");
            int strength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у тебя золота?");
            int gold = Convert.ToInt32(Console.ReadLine());

            int health = 100;

            Console.WriteLine($"Привет, {name}! Ты {classHero} в возрасте {age} лет. Сила: {strength}, Золото: {gold}, Здоровье = 100");
        }
    }
}
