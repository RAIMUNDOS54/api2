using api2.Services;

namespace api2.Controllers
{
    public class ExpenseController
    {
        private readonly ExpenseService expenseService = new();

        public async Task<List<Expense>> GetExpensesAsync()
        {
            return await expenseService.GetAllExpensesAsync();
        }

        public async Task<Expense> GetExpenseAsync(int ID)
        {
            return await expenseService.GetExpenseAsync(ID);
        }

        public async Task<Expense> CreateExpenseAsync(Expense expense)
        {
            return await expenseService.CreateExpenseAsync(expense);
        }
    }
}
