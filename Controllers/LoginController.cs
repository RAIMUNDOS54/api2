using api2.Services;

namespace api2.Controllers
{
    public class LoginController
    {
        private readonly UserService userService = new();

        public async Task<string> LoginAsync(User user)
        {
            return await userService.GetUserAsync(user);
        }
    }
}
