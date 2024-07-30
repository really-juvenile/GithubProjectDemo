namespace DiceDictionaryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionarydictionary = new Dictionary<int, int>
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0},
            };

            int rollDice = 0;

            //program for rollling dice and counting the frequency in the dictionary C#


             Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                rollDice = random.Next(1, 7);
                if (dictionarydictionary.ContainsKey(rollDice))
                {
                    dictionarydictionary[rollDice]++;
                    Console.WriteLine("Hello World")

                }

                
            }

            foreach( var  i in dictionarydictionary)
            {
                Console.WriteLine(i.Key +" " +i.Value);
            }


           

            //if (rollDice == 0)
            //{
            //    rollDice = 1;


            //    Console.WriteLine(rollDice);
            //}


        }
    }
}
