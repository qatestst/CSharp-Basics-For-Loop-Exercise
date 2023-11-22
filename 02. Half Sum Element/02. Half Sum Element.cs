namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;


            for (int i = 0; i < number; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                { 
                max = num;
                }
            }
            int sumWithoutMaxNumber = sum - max;
            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else 
            {
            int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);

            }
        }
    }
}