using api2.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

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
            app?.MapPost("/api/auth",
            async (User user) =>
            {
                return await new LoginController().LoginAsync(user);
            });

            app?.MapGet("/api/expenses",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async () =>
            {
                return await new ExpenseController().GetExpensesAsync();
            });

            app?.MapGet("/api/expenses/{ID}",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (int ID) =>
            {
                return await new ExpenseController().GetExpenseAsync(ID);
            });

            app?.MapPost("/api/expenses/expense",
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            async (Expense expense) =>
            {
                return await new ExpenseController().CreateExpenseAsync(expense);
            });
        }
    }
}
