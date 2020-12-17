using System;
using System.IO;
using System.Linq;

namespace lab4_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines;

            int count = 0;
            int mul_sum = 0;
            double result;
            int first;
            int second;

            for (int i = 10; i < 30; i++)
            {
                try
                {
                    lines = File.ReadLines("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\" + i + ".txt").Take(2).ToArray();
                    first = Convert.ToInt32(lines[0], 10);
                    second = Convert.ToInt32(lines[1], 10);
                    try
                    {
                        mul_sum += checked(first * second);
                        count++;
                    }
                    catch (OverflowException e)
                    {
                        try
                        {
                            File.AppendAllText("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\overflow.txt", i + ".txt" + "\n");

                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            Console.WriteLine("Can`t open the file overflow.txt");
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    try
                    {
                        File.AppendAllText("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\\\no_file.txt", i + ".txt" + "\n");
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("Can`t open the file no_file.txt");
                    }
                }
                catch (OverflowException e)
                {
                    try
                    {
                        File.AppendAllText("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\overflow.txt", i + ".txt" + "  \n");
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("Can`t open the file bad_data.txt");
                    }
                }
                catch (FormatException e)
                {
                    try
                    {
                        File.AppendAllText("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\\\bad_data.txt", i + ".txt" + "  \n");
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("Can`t open the file bad_data.txt");
                    }
                }

                catch (ArgumentOutOfRangeException e)
                {
                    try
                    {
                        File.AppendAllText("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\\\bad_data.txt", i + ".txt" + "  \n");
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("Can`t open the file bad_data.txt");
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    try
                    {
                        File.AppendAllText("C:\\Users\\asus\\source\\repos\\lab4_exceptions\\lab4_exceptions\\txt\\\\bad_data.txt", i + ".txt" + "  \n");
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("Can`t open the file bad_data.txt");
                    }
                }
            }
            result = mul_sum / count;
            Console.WriteLine("Середнє арифметичне добуткiв:" + result);
            Console.ReadKey();

        }
    }
}
