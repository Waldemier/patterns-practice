using TemplateMethod.Implementation;

Expenses expenses = new WageExpenses();
expenses.SpendMoney();
expenses = new CorporateExpenses();
expenses.SpendMoney();
expenses = new StationeryExpenses();
expenses.SpendMoney();
