namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int numberOfJuryMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfJuryMembers; i++) 
            { 
                string juryMember = Console.ReadLine();
                double juryMemberPoints = double.Parse(Console.ReadLine());

                points = points + ((juryMember.Length * juryMemberPoints) / 2);

                if(points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
                    break;
                }



            }
            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:F1} more!");
            }
        }
    }
}