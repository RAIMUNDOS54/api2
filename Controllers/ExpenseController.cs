using api2.Services;

namespace api2.Controllers
{
    public class ExpenseController
    {
        private readonly ExpenseService expenseService = new();

        public async Task<List<Expense>> GetExpenses()
        {
            return await expenseService.GetAllExpenses();
        }

        public async Task<Expense> GetExpense(int ID)
        {
            return await expenseService.GetExpense(ID);
        }

        public async Task<Expense> CraeteExpense(Expense expense)
        {
            return await expenseService.CreateExpense(expense);
        }
    }
}
