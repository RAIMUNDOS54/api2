namespace api2.Repositories
{
    public class ExpenseRepository
    {
        private readonly ExpenseDbContext dbContext = new();

        public async Task<List<Expense>> GetAllExpenses()
        {
            return await dbContext.Expenses.ToListAsync();
        }

        public async Task<Expense> GetExpense(int ID)
        {
            return await dbContext.Expenses.Where(e => e.Id == ID).FirstOrDefaultAsync();
        }

        public async Task<Expense> CreateExpense(Expense expense)
        {
            _ = await dbContext.Expenses.AddAsync(expense);
            
            _ = await dbContext.SaveChangesAsync();

            return expense;
        }
    }
}
