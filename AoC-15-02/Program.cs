using System.ComponentModel.DataAnnotations;

namespace AoC_15_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int neededWrapping = 0;
            int neededRibbon = 0;
            Box current;
            try
            {
                using (StreamReader sr = new StreamReader(System.IO.File.OpenRead("input02.txt")))
                {
                    while (!sr.EndOfStream)
                    {
                        current = new Box(sr.ReadLine());
                        neededWrapping += current.requiredArea();
                        neededRibbon += current.requiredRibbon();
                        //Console.WriteLine(String.Format("Box l{0}w{1}h{2} has a volume of {3} and a required ribbon of {4} adding to a total of {5}", current.getLength(), current.getWidth(), current.getHeight(), current.volume(), current.requiredRibbon(), neededRibbon));
                    }
                }
            }
            catch (Exception e){ Console.WriteLine("Error: " + e.Message); }
            Console.WriteLine(String.Format("We are going to need {0} square feet of wrapping paper.", neededWrapping));
            Console.WriteLine(string.Format("We are also going to need {0} feet of ribbon.", neededRibbon));
        }
    }
}