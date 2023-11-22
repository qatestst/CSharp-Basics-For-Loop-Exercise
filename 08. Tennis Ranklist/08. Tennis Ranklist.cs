namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tournamentsNumber = double.Parse(Console.ReadLine());
            
            double primaryPoints = double.Parse(Console.ReadLine());
            double points = 0;
            int won = 0;
             for ( int i = 0; i < tournamentsNumber; i++ ) 
            {
                string stage = Console.ReadLine();
                switch( stage ) 
                {
                    case "W": points += 2000; won++; break;
                    case "F": points += 1200; break;
                    case "SF": points += 720; break;
                
                }
            
            }
            double totalPoints = primaryPoints + points;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(points/tournamentsNumber):F0}");
            double percentsWon = (won / tournamentsNumber)*100;
            Console.WriteLine($"{percentsWon:F2}%");

        }
    }
}