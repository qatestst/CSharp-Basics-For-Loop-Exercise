namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMashinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;
            int numberOfToys = 0;
            int sumForBirthday = 10;
           
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                { 
                numberOfToys++;
                }
                else if (i%2 == 0) 
                {
                    money += sumForBirthday-1;
                    sumForBirthday += 10;
                  
                }
                           
            }
            double sumFromSoldToys = numberOfToys * toyPrice;
            double savedMoney = sumFromSoldToys + money;
            if (savedMoney - washMashinePrice >= 0)
            { Console.WriteLine($"Yes! {savedMoney - washMashinePrice:F2}"); }
            else
            { Console.WriteLine($"No! {washMashinePrice - savedMoney:F2}"); }
        }
    }
}