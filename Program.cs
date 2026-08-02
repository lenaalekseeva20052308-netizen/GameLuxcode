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

            Console.WriteLine("Выбери путь: 1 - Огненный лес, 2 - Мост судьбы");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Ты идешь через лес. Теряешь 20 единиц здоровья из-за споров ядовитых грибов на стволах деревьев");
                health -= 20;
            }

            else if (choice == "2")
            {
                Console.WriteLine("Ты идёшь к мосту. На входе стоит стражник. Он требует оплату за вход. Ты отдаёшь ему 10 золота. Стражник потребовал ещё. Вы ввязались в драку. Потеряли 5 единиц здоровья");
                gold -= 10;
                health -= 5;
            }

            else
            {
                Console.WriteLine("Ты стоишь на месте и теряешь драгоценное время. Дракон становится сильнее!");
            }

            Console.WriteLine($"Твоё здоровье: {health}. Золото: {gold}");
        }
    }
}
