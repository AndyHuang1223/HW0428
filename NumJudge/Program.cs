namespace NumJudge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var num = int.Parse(input);
            if (IsOdd(num))
            {
                Console.WriteLine($"{num} 是奇數!");
            }
            else
            {
                Console.WriteLine($"{num} 是偶數!");
            }
        }

        private static bool IsOdd(int num)
        {
            return num % 2 != 0;  
        }
    }
}
