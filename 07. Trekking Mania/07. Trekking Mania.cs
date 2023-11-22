namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double p1 = 0; // •	Група до 5 човека – изкачват Мусала
            double p2 = 0; // •	Група от 6 до 12 човека – изкачват Монблан
            double p3 = 0; // •	Група от 13 до 25 човека – изкачват Килиманджаро
            double p4 = 0; // •	Група от 26 до 40 човека –  изкачват К2
            double p5 = 0; // •	Група от 41 или повече човека – изкачват Еверест
            double totalTrekkers = 0;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num <=5) { p1 += num; totalTrekkers += num; }
                else if (num >= 6 && num <= 12) { p2+= num;totalTrekkers += num; }
                else if (num >= 13 && num <= 25) { p3+=num; totalTrekkers += num; }
                else if (num >= 26 && num <= 40) { p4+=num; totalTrekkers += num; }
                else if (num >= 41) { p5+=num; totalTrekkers += num; }

            }

            double p1Percent = (p1 / totalTrekkers) * 100;
            double p2Percent = (p2 / totalTrekkers) * 100;
            double p3Percent = (p3 / totalTrekkers) * 100;
            double p4Percent = (p4 / totalTrekkers) * 100;
            double p5Percent = (p5 / totalTrekkers) * 100;

            Console.WriteLine($"{p1Percent:F2}%");
            Console.WriteLine($"{p2Percent:F2}%");
            Console.WriteLine($"{p3Percent:F2}%");
            Console.WriteLine($"{p4Percent:F2}%");
            Console.WriteLine($"{p5Percent:F2}%");


        }
    }
}