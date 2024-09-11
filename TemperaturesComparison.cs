using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        double[] temps = { 0, 0, 0, 0, 0 };
        string tempOne;
        int tempOneVal;
        Console.WriteLine("Enter five temperatures for each day in fahrenheit.");

        for (int i = 0; i < temps.Length; i++)
        {
            tempOne = Console.ReadLine();
            tempOneVal = Convert.ToInt32(tempOne);
            if (tempOneVal < 130 && tempOneVal > -30)
            {
                temps[i] = temps[i] + tempOneVal;

            }
            else
            {
                Console.WriteLine("Temperature {0} is invalid, Please enter a valid temperature between -30 and 130.", tempOne);
                i--;
            }

        }
        if (temps[0] < temps[1] && temps[1] < temps[2] && temps[2] < temps[3] && temps[3] < temps[4])
        {
            Console.WriteLine("\nIt's Getting Warmer.");
        }
        else if (temps[0] > temps[1] && temps[1] > temps[2] && temps[2] > temps[3] && temps[3] > temps[4])
        {
            Console.WriteLine("\nIt's Getting Colder.");
        }
        else
        {
            Console.WriteLine("\nIt's a Mixed Bag.");
        }
        Console.WriteLine("5-day Temperature [{0}, {1}, {2}, {3}, {4}]", temps[0], temps[1], temps[2], temps[3], temps[4]);
        double avgTemp = (temps.Sum()) / 5;
        Console.WriteLine("Average Temperature is {0} degrees.", avgTemp);
    }
}
