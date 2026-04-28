namespace LoopReverse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入用,分隔的字串");
            var input = Console.ReadLine();
            var strArr = input.Split(',');

            for(var i = 0; i < strArr.Length / 2; i++)
            {
                var targetIdx = strArr.Length - 1 - i;
                var temp = strArr[targetIdx];
                strArr[targetIdx] = strArr[i];
                strArr[i] = temp;
            }

            Console.WriteLine(string.Join(",", strArr));
        }
    }
}
