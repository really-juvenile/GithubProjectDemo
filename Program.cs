namespace DiceDictionaryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>
            {
                {1,0 },
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0},
            };

            Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {


                int rollDice = 0;

            //program for rollling dice and counting the frequency in the dictionary C#


             Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                rollDice = random.Next(1, 7);
                if (dictionary.ContainsKey(rollDice))
                {
                    dictionary[rollDice]++;



                    { 1,0 },
                { 2,0},
                { 3,0},
                { 4,0},
                { 5,0},
                { 6,0},
            };

                int rollDice = 0;


                char[] charArray = new char[10];    

            }


        }

            foreach( var  i in dictionary)
            {
                Console.WriteLine(i.Key +" " +i.oi  wbdbbowudbJ CValue);
            }


           


           

            //if (rollDice == 0)
            //{
            //    rollDice = 1;


            //    Console.WriteLine(rollDice);
            //}


        }
    }
}
