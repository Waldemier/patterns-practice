namespace TemplateMethod.Implementation
{
    public class CorporateExpenses : Expenses
    {
        public override void SpendMoney()
        {
            Console.WriteLine("Spent on corporate");
        }
    }
}
