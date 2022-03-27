namespace BizDayCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekendRule numberOne = new WeekendRule();
            bool valid = numberOne.CheckIsBusinessDay(new DateTime(2016, 6, 27));
            Console.WriteLine(valid);

        }
    }
}
