namespace Task_15_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "каша";
            string word2 = "малаша";
            System.Console.WriteLine(word1);
            System.Console.WriteLine(word2);
            System.Console.WriteLine();
            var microBuses = word1.CoupledChars(word2);
            foreach (char ch in microBuses)
            {
                System.Console.WriteLine(ch);
            };
        }
    }
}
