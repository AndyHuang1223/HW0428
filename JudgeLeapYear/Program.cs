using System.Globalization;

namespace JudgeLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入民國年:");
            var input = Console.ReadLine();
            var mingoYear = int.Parse(input);

            var twCal = new TaiwanCalendar();

            if (twCal.IsLeapYear(mingoYear))
            {
                Console.WriteLine("是閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }


            var year = mingoYear + 1911;
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("是閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }
        }
    }
}
