namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            
            double p1 = 0; // numbers <200
            double p2 = 0; // numbers 200-399
            double p3 = 0; // numbers 400-599
            double p4 = 0; // numbers 600 - 799
            double p5 = 0; // numbers >800

            for (int i = 0; i < number; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200) { p1++; }
                else if (num >= 200 && num <=399) { p2++; }
                else if (num >= 400 && num <= 599) { p3++; }
                else if (num >= 600 && num <= 799) { p4++; }
                else if (num >= 800) { p5++; }
            
            }

            double p1Percent = (p1 / number) * 100;
            double p2Percent = (p2 / number) * 100;
            double p3Percent = (p3 / number) * 100;
            double p4Percent = (p4 / number) * 100;
            double p5Percent = (p5 / number) * 100;

            Console.WriteLine($"{p1Percent:F2}%");
            Console.WriteLine($"{p2Percent:F2}%");
            Console.WriteLine($"{p3Percent:F2}%");
            Console.WriteLine($"{p4Percent:F2}%");
            Console.WriteLine($"{p5Percent:F2}%");
            
            
        }
    }
}