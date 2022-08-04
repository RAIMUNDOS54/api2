using api2.Controllers;

namespace api2.Configurations
{
    public class ControllerConfiguration : API2Configuration
    {
        public ControllerConfiguration()
        {
            Config();
        }

        internal sealed override void Config()
        {
            app?.MapGet("/api/expenses",
            async () =>
            {
                return await new ExpenseController().GetExpenses();
            });

            app?.MapGet("/api/expenses/{ID}",
            async (int ID) =>
            {
                return await new ExpenseController().GetExpense(ID);
            });

            app?.MapPost("/api/expenses/expense",
            async (Expense expense) =>
            {
                return await new ExpenseController().CraeteExpense(expense);
            });
        }
    }
}
