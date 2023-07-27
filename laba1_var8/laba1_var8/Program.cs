using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 50);
            Console.CursorVisible = false;

            var random = new Random();

            int Background = random.Next(1, 16);
            int Foreground = random.Next(1, 16);

            while (Background == Foreground)
            {
                Background = random.Next(1, 16);
                Foreground = random.Next(1, 16);
            }

            Console.BackgroundColor = (ConsoleColor)Background;
            Console.ForegroundColor = (ConsoleColor)Foreground;

            Console.Title = "Тимур";
            Console.Clear();

            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Привет " + name + " " + surname);
            Console.Beep();

            Console.Write("CapsLoock: " + (Console.CapsLock ? "on" : "off") + "\r\n");

            Console.Write("NumLoock: " + (Console.NumberLock ? "on" : "off") + "\r\n");
            Console.Write("\r\n");



            Console.Write("Введите число a: ");
            double a = Convert.ToInt32(Console.ReadLine());

            if(a == 0)
            {
                Console.Write("a == 0");
                System.Environment.Exit(1);
            }

            Console.Write("Введите число b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
            {
                Console.Write("a == 0");
                System.Environment.Exit(1);
            }

            Console.Write("\r\n");

            double c = 0;

            c = a + b;
            Console.Write("сумма a + b = " + c );
            Console.Write("\r\n");
            c = a - b;
            Console.Write("разность a - b = " + c);
            Console.Write("\r\n");
            c = (a*a) / (b*b);
            Console.Write("частное a / b = " + c);
            Console.Write("\r\n");
            c = a * b;
            Console.Write("произведение a * b = " + c);
            Console.Write("\r\n");
            Console.Write("\r\n");



            Console.Write("Введите день (в диапазоне от 1 - 365): ");
            double day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day > 365){
                Console.Write("введено не то число");
                System.Environment.Exit(1);
            }
            double days = day;

            while (day >= 7)
                day -= 7;

            switch (day)
            {
                case 0:
                    Console.Write(days + " числа было воскресенье");
                    break;

                case 1:
                    Console.Write(days + " числа был понедельник");
                    break;

                case 2:
                    Console.Write(days + " для был вторник");
                    break;

                case 3:
                    Console.Write(days + " числа была среда");
                    break;

                case 4:
                    Console.Write(days + " числа был четверг");
                    break;

                case 5:
                    Console.Write(days + " числа была пятница");
                    break;

                case 6:
                    Console.Write(days + " числа была суббота");
                    break;

                default:
                    Console.Write("что-то пошло не так :)");
                    break;
            }


        }
    }
}