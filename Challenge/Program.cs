namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine();
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount entries {0}", count);
                Console.Write("Please enter -1 once you are ready to calculate the average : "); 
                 
                input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("-------------------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average scores of your students is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if(!(input == "-1"))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }
                count++;
            }
            Console.Read();
        }
    }
}