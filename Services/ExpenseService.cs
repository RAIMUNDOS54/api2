using api2.Repositories;

namespace api2.Services
{
    public class ExpenseService
    {
        private readonly ExpenseRepository expenseRepository = new();

        public async Task<List<Expense>> GetAllExpenses()
        {
            return await expenseRepository.GetAllExpenses();
        }

        public async Task<Expense> GetExpense(int ID)
        {
            return await expenseRepository.GetExpense(ID);
        }

        public async Task<Expense> CreateExpense(Expense expense)
        {
            return await expenseRepository.CreateExpense(expense);
        }
    }
}
