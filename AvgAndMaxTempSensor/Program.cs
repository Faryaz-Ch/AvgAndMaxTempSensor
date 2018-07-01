using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>  
    /// In this C# program, the user will simulate the sensors by entering the data. 
    /// Program will 1st ask from the user for how many sensors are currently being deployed. The received 
    /// number is then used (as array capacity) to create an array of temperatures (data type: double). The 
    /// program then uses a loop to read the temperature values from the user and save in the array (Hint: you’ll 
    /// have to use the array length to control the iteration of the loop). Your program should calculate and display the average temperature.
    /// Author: Faryaz
    /// </summary>

    class MainClass
    {
        public static void Main(string[] args)
        {
            AvgAndMaxTempSensor();

        }
        static void AvgAndMaxTempSensor()
        {
            Write("How many sensors are currently collecting Data: ");
            int sens = int.Parse(ReadLine());
            double[] temp = new double[sens];

            for (int i = 0; i < sens; i++)
            {
                Write($"Enter Temperature No. {i + 1} = ");
                temp[i] = double.Parse(ReadLine());
            }

            double sum = 0;

            foreach (double n in temp)
            {
                sum = temp.Sum();
            }
            double average = sum / temp.Length;
            WriteLine($"Average Temperature: {average} Out of {sens} sensors: ");

            double Max_Temperature = temp.Max();
            WriteLine($"Maximum Temperature: {Max_Temperature}");

            double count2 = 0;
            foreach (double n in temp)
            {
                if (n > 10 && n < 20)
                {
                    count2++;
                }
            }
            WriteLine($"There are {count2} temperature between 10-20.");
            WriteLine();


        }
    }
}