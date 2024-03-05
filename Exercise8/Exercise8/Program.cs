namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your maximum number? ");
            int maxNum = int.Parse(Console.ReadLine());
            for (int i = 0;
             i <= maxNum;
                i = i + 2)
            {
                Console.WriteLine(i);

            }
        }
    }
}