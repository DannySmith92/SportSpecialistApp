
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Application.Repositories
{
    public interface I_UserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        public Task<bool> CheckPassword(User user, string password);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<SignInResult> LoginAsync(LoginModel model);
        Task<SignInResult> LoginEmailAsync(User user, string password, bool remember);
        Task LogoutAsync();
        public Task<IList<User>> GetAllUser();
        public Task<IList<User>> GetAllAgent();
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<SignInResult> ValidatePasswordAsync(User user, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<string> GenerateEmailConfirmationTokenAsync(User user);
        Task<IdentityResult> ConfirmEmailAsync(User user, string token);
        Task<User> GetUserByIdAsync(string userId);
        Task<User> GetUserByNameAsync(string name);
        Task<string> GenerateForgotPasswordTokenAsync(User user);
        Task<string> GeneratePasswordResetTokenAsync(User user);
        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);
        Task<IdentityResult> UpdateUserRoleAsync(User user, string newRoleName);
        Task<bool> DeleteUser(string idUser);
    }
}
