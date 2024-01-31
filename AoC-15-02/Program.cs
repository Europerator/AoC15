using System.ComponentModel.DataAnnotations;

namespace AoC_15_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int neededWrapping = 0;
            try
            {
                using (StreamReader sr = new StreamReader(System.IO.File.OpenRead("input02.txt")))
                {
                    while (!sr.EndOfStream)
                    {
                        neededWrapping += (new Box(sr.ReadLine())).requiredArea();
                    }
                }
            }
            catch (Exception e){ Console.WriteLine("Error: " + e.Message); }
            Console.WriteLine(String.Format("We are going to need {0} square feet of wrapping paper.", neededWrapping));
        }
    }
}