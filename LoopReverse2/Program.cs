namespace LoopReverse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入1-9的數字: ");
            var input = Console.ReadLine();
            var inputNum = int.Parse(input); //3
            var layer = 1;

            for(int num = inputNum; num > 0; num--)
            {
                for(int j = 0; j < layer; j++)
                {
                    Console.Write(num);
                }
                layer++;
                Console.WriteLine();
            }

        }
    }
}
