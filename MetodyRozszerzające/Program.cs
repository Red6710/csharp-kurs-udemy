namespace MetodyRozszerzające
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7,0,0,0));
            DateTime after = now.AddDays(1);
            bool isDateBetween = utils.IsDateBetween(now, before, after);

            bool isDateBetween2 = now.IsBetween(before, after);
        }
    }
}
