namespace NumJudge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入用,分隔的數字");
            var input = Console.ReadLine();
            //切,
            var arr = input.Split(',');

            var tempNumArr = new int[arr.Length];

            for(var i = 0; i < tempNumArr.Length; i++)
            {
                tempNumArr[i] = int.Parse(arr[i]);
            }

            //先排序

            Array.Sort(tempNumArr);//排原本陣列(就地排)
            
            
            // 5:  0,0,0,0,0
            //奇數的List 偶數的List
            var oddList = new List<int>();
            var evenList = new List<int>();

            foreach(var item in tempNumArr)
            {
                if (IsOdd(item))
                {
                    oddList.Add(item);
                }
                else
                {
                    evenList.Add(item);
                }
            }

            Console.WriteLine($"奇數: {string.Join(",", oddList)}");
            Console.WriteLine($"偶數: {string.Join(",", evenList)}");



            //foreach(var item in arr)
            //{
            //    var num = int.Parse(item);

            //    if (IsOdd(num))
            //    {
            //        oddList.Add(num);
            //    }
            //    else
            //    {
            //        evenList.Add(num);
            //    }
            //}

            ////排序(回傳新的) 3,5,1,7
            //var sortedOddResult = oddList.OrderBy((num) => num);
            //var sortedEvenResult = evenList.OrderBy(num => num);

            //Console.WriteLine($"奇數: {string.Join(",", sortedOddResult)}");
            //Console.WriteLine($"偶數: {string.Join(",", sortedEvenResult)}");

        }

        private static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}
