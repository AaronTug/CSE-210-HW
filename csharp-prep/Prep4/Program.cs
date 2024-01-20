using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> form = new List<int>();
        int num;
        int sum = 0;
        int count;
        int average;
        int largest = 0;
        Console.WriteLine("Please enter a number to add to the form, add 0 when done.");

        do
        {
            string inter;
            Console.Write("Enter number: ");
            inter = Console.ReadLine();
            num = int.Parse(inter);
            form.Add(num);
        } while (num != 0);

        foreach (int numb in form)
        {
            sum = sum + numb;
            if (numb > largest)
            {
                largest = numb;
            }
        }
        count = form.Count - 1;
        average = sum / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}