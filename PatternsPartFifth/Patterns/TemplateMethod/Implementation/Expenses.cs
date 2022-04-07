namespace TemplateMethod.Implementation
{
    public abstract class Expenses
    {
        public void TemplateMethod()
        {
            SpendMoney();
        }
        public abstract void SpendMoney();
    }
}
