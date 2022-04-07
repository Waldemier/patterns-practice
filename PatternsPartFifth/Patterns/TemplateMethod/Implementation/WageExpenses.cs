namespace TemplateMethod.Implementation
{
    public class WageExpenses : Expenses
    {
        public override void SpendMoney()
        {
            Console.WriteLine("Spent on wages");
        }
    }
}
