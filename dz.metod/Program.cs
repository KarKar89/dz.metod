using System;

namespace GuessTheNumberSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string answer;

            do
            {
                int secret = random.Next(1, 101);
                int attempts = 0;
                bool guessed = false;

                Console.WriteLine("Я загадал число от 1 до 100. У вас 7 попыток.");

                while (attempts < 7)
                {
                    attempts++;
                    Console.Write($"Попытка {attempts}: ");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == secret)
                    {
                        Console.WriteLine($"Угадали! Это число {secret}.");
                        guessed = true;
                        break;
                    }
                    else if (guess < secret)
                        Console.WriteLine("Больше.");
                    else
                        Console.WriteLine("Меньше.");
                }

                if (!guessed)
                    Console.WriteLine($"Не угадали. Было загадано {secret}.");

                Console.Write("Сыграть ещё раз? (да/yes): ");
                answer = Console.ReadLine();
            }
            while (answer == "да" || answer == "yes");

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}