using System;
using SplashKitSDK;
#nullable disable

namespace Lists
{
    public class Program
    {
        private static List<double> _values = new List<double>();
        public enum UserOption
        {
            NewValue,
            Sum,
            Print,
            Quit
        }
        public static void Main()
        {
            UserOption userSelection;
            do
            {
                userSelection = ReadUserOption();
                switch (userSelection)
                {
                    case UserOption.NewValue:
                        AddValueToList();
                        break;
                    case UserOption.Sum:
                        Sum();
                        break;
                    case UserOption.Print:
                        Print();
                        break;
                    case UserOption.Quit:
                        Console.WriteLine("\nQuitting..");
                        break;

                }
            }
            while (userSelection != UserOption.Quit);
        }
        public static double ReadDouble(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid value");
                }
            }

        }


        public static void AddValueToList()
        {

            double value = ReadDouble("\nEnter a Value: ");
            _values.Add(value);
        }

        public static void Print()
        {
            foreach (double value in _values)
            {
                Console.WriteLine($"Number you entered is: {value}");
            }
        }

        public static void Sum()
        {
            double sum = 0;
            foreach (double value in _values)
            {
                sum += value;
            }

            Console.WriteLine($"\nTotal: {sum}");
        }

        public static UserOption ReadUserOption()
        {
            Console.WriteLine("Choose an option [0 - 3]: \n");
            Console.WriteLine("**********************************\n");
            Console.WriteLine("0 - Add Value");
            Console.WriteLine("1 - Sum of all values");
            Console.WriteLine("2 - Print");
            Console.WriteLine("3 - Quit");
            Console.WriteLine("**********************************");
            int option = 3;
            Int32.TryParse(Console.ReadLine(), out option);
            return (UserOption)option;

        }
    }
}
