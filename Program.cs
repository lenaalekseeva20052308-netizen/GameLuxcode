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

            int stamina = 100;
            int days = 0;

            Console.WriteLine($"Привет, {name}! Ты {classHero} в возрасте {age} лет. Сила: {strength}, Золото: {gold}, Здоровье = 100");


            Console.WriteLine("Выбери путь: 1 - Огненный лес, 2 - Мост судьбы, 3 - Пещера тролля");
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

            else if (choice == "3")
            {
                Console.WriteLine("Ты попал(-а) в пещеру тролля. Для пропуска он потребовал 50 единиц золота. Ты отдаёшь ему оплату. Тролль захотел украсть твой мешочек с деньгами. Вы начинаете драку и побеждаете в ней. В качестве моральной компенсации вы забираете сокровища тролля в размере 100 золотых монет!");
                gold += 100;
            }

            else
            {
                Console.WriteLine("Ты стоишь на месте и теряешь драгоценное время. Дракон становится сильнее!");
            }

            Console.WriteLine($"Твоё здоровье: {health}. Золото: {gold}");

            Random rand = new Random();
            Console.WriteLine("Впереди виднеется пустыня!");
            Console.WriteLine("Выбери сложность перехода: 1 - Лёгкая (5 дней), 2 - Средняя (7 дней), 3 - Сложная (10 дней)");
            string difficulty = Console.ReadLine();

            int maxDays;
            if (difficulty == "1")
            {
                maxDays = 5;
            }
            else if (difficulty == "2")
            {
                maxDays = 7;
            }
            else
            {
                maxDays = 10;
            }



            while (stamina > 0 && days < maxDays)
            {
                int stormChance = rand.Next(1, 6);
                if (stamina <= 50) Console.WriteLine("Ты скоро упадешь в обморок! Срочно выпей воды!");

                Console.WriteLine($"День {days + 1}. Твоя выносливость, {name}: {stamina}");
                Console.WriteLine("Нажми 1, чтобы найти воду, или любую другую клавишу, чтобы продолжить путь.");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    stamina += 40;
                    Console.WriteLine("ты нашел воду! Выносливость пополнилась!");
                }

                stamina -= 30;
                days++;

                if (stormChance == 1)
                {

                }

                if (stamina < 0) stamina = 0;

                Console.WriteLine($"Выносливость после дня:{stamina}\n");
            }

            if (stamina <= 50) Console.WriteLine("Ты упал в обморок! Путешествие окончено...");
            else Console.WriteLine("Ты пересек пустыню!");
        }
    }
}
