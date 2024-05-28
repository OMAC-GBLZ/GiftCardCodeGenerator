namespace Gift_Card_Code_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to generate a code");
            Console.ReadLine();
            Console.Clear();

            Dictionary<int, char> characterCollection = new Dictionary<int, char>()
            {
                {1,'A'},{2,'B'},{3,'C'},{4,'D'},{5,'E'},{6,'F'},{7,'G'},{8,'H'},
                {9,'I'},{10,'J'},{11,'K'},{12,'L'},{13,'M'},{14,'N'},{15,'O'},{16,'P'},
                {17,'Q'},{18,'R'},{19,'S'},{20,'T'},{21,'U'},{22,'V'},{23,'W'},{24,'X'},
                {25,'Y'},{26,'Z'},{27,'0'},{28,'1'},{29,'2'},{30,'3'},{31,'4'},{32,'5'},
                {33,'6'},{34,'7'},{35,'8'},{36,'9'},
            };

            Random random = new Random();

            Console.WriteLine("YOUR CODE IS: \n \n \n ");

            for (int i = 1; i <= 16; i++)
            {
                char result;
                int rnd = random.Next(characterCollection.Count);
                characterCollection.TryGetValue(rnd, out result);
                Console.Write(result);
                if (i % 4 == 0 && i < 16)
                {
                    Console.Write('-');
                }
            }

            Console.WriteLine("\n \n \n");
            Console.Beep();

            //TODO use string builder to create a variable to store the result.
            //Store result in new class with information about the code, i.e., if it has been redeemed, the value & expiry date
        }
    }
}
