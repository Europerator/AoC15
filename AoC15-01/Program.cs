
using System.Collection.generic;
namespace AoC15_01
{
    public class Program
    {
        public static int floor(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') { result++; }
                else if (input[i] == ')') { result--; }
            }
            return result;
        }
        public static int firstToBasement(string input)
        {
            int position = 0;
            string path = "";
            bool basement = false;
            for (int i = 0; i < input.Length && !basement; i++)
            {
                path += input[i];
                if (floor(path) == -1) { basement = true; position = i + 1; }
            }
            return position;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2015, day 1");

            try
            {
                using (var sr = new StreamReader("input.txt"))
                {
                    string input = sr.ReadToEnd();
                    Console.WriteLine("The instructions will take Santa to the floor number: " + floor(input) +
                        ". And the position of the character causing him to first enter the basement is: " + firstToBasement(input));
                }
            }
            catch (IOException e) { Console.WriteLine("input missing : " + e.ToString()); }
            catch (Exception f) { Console.WriteLine("other error : " + f.ToString()); }
        }
    }
}