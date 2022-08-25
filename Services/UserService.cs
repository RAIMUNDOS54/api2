using api2.Repositories;

namespace api2.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository = new();

        internal async Task<string> GetUserAsync(User user)
        {
            return await userRepository.LoginAsync(user);
        }
    }
}
