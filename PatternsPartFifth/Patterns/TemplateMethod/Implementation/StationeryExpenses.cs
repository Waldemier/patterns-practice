namespace TemplateMethod.Implementation
{
    public class StationeryExpenses : Expenses
    {
        public override void SpendMoney()
        {
            Console.WriteLine("Spent on stationery");
        }
    }
}
