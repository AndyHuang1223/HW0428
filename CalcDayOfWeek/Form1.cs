namespace CalcDayOfWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //使用迴圈算
            var input = textBox1.Text;
            var year = int.Parse(input);

            var currDate = new DateTime(year, 1, 1);
            var finalDate = new DateTime(year, 12, 31);

            var sat = 0;
            var sun = 0;

            while (currDate <= finalDate)
            {
                if (currDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    sat++;
                }

                if (currDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    sun++;
                }

                currDate = currDate.AddDays(1);
            }
            DisplayResult(sat, sun);
            //MessageBox.Show($"星期六:{sat} 天, 星期天:{sun} 天");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            var year = int.Parse(input);

            var sat = CalcDayOfWeek(year, DayOfWeek.Saturday);
            var sun = CalcDayOfWeek(year, DayOfWeek.Sunday);

            //MessageBox.Show($"星期六:{sat} 天, 星期天:{sun} 天");
            DisplayResult(sat, sun);
        }

        private void DisplayResult(int sat, int sun)
        {
            MessageBox.Show($"星期六:{sat} 天, 星期天:{sun} 天");
        }

        private int CalcDayOfWeek(int year, DayOfWeek dayOfWeek)
        {
            var startDate = new DateTime(year, 1, 1);
            var finalDate = new DateTime(year, 12, 31);
            if (startDate.DayOfWeek == dayOfWeek || finalDate.DayOfWeek == dayOfWeek)
            {
                return 53;
            }

            return 52;
        }
    }
}
