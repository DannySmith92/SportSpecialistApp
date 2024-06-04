
using Application.Repositories;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository : I_UserRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<User> GetUserByNameAsync(string name)
        {
            return await _userManager.FindByNameAsync(name);
        }

        public async Task<IdentityResult> UpdateUserAsync(User user)
        {
            return await _userManager.UpdateAsync(user);
        }

        public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
        {
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return await _userManager.ResetPasswordAsync(user, token, newPassword);
        }

        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
            return await _signInManager.PasswordSignInAsync(model.UserName,
                model.Password,
                model.RememberMe,
                false
               );
        }

        public async Task<SignInResult> LoginEmailAsync(User user, string password, bool remember)
        {
            return await _signInManager.CheckPasswordSignInAsync(user,
                password,
                false
               );
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<SignInResult> ValidatePasswordAsync(User user, string password)
        {
            return await _signInManager.CheckPasswordSignInAsync(user, password, false);
        }

        public async Task<bool> CheckPassword(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<IList<User>> GetAllUser()
        {
            return await _userManager.GetUsersInRoleAsync("Customer");
        }

        public async Task<IList<User>> GetAllAgent()
        {
            var list = await _userManager.GetUsersInRoleAsync("Agent");

            return list;
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }

        public async Task<IdentityResult> ConfirmEmailAsync(User user, string token)
        {
            return await _userManager.ConfirmEmailAsync(user, token);
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(User user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public async Task<string> GenerateForgotPasswordTokenAsync(User user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(User user)
        {
            return await _userManager.GeneratePasswordResetTokenAsync(user);
        }
        public async Task<IdentityResult> ResetPasswordAsync(User user, string token, string password)
        {
            return await _userManager.ResetPasswordAsync(user, token, password);
        }
        public async Task<IdentityResult> UpdateUserRoleAsync(User user, string newRoleName)
        {
            await CheckRoleAsync(newRoleName);
            var currentRoles = await _userManager.GetRolesAsync(user);
            if (currentRoles != null)
            {
                await _userManager.RemoveFromRolesAsync(user, currentRoles);
            }
            return await _userManager.AddToRoleAsync(user, newRoleName);

        }

        public async Task<bool> DeleteUser(string idUser)
        {
            var user = await _userManager.FindByIdAsync(idUser);
            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;

            }
        }
    }
}
