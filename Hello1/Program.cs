using System;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)

        {
            ValueTypes();
            for (; ; )
            {
                Greeting();
                Age();
                Settings();

                //foreach (var item in args)
                //{
                //    Console.WriteLine("witaj, "+item);
                //}

            }
        }

        private static void ValueTypes()
        {
           int maxInt = int.MaxValue;
           int minInt = int.MinValue;
           long maxLong = long.MaxValue;
           long minLong = long.MinValue;

           Console.WriteLine("maxInt = " + maxInt);
           Console.WriteLine("minInt = " + minInt);
           Console.WriteLine("maxLong = " + maxLong);
           Console.WriteLine("minLong = " + minLong);

        }


        /// <summary>
        /// Ustawienia programu
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// wypisujemy komunikat zlażny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("wpisz swój wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("brawo . jestes pełnoletnie, możesz pić alkohol");

            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("wprowadziłeś niepoprawny wiek!");

            }



            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("niestety jesteś dzieckiem, pijesz mleko");
            }
        }

        /// <summary>
        /// wypisujemy powietanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("witaj ," + name);
        }
    }
}
