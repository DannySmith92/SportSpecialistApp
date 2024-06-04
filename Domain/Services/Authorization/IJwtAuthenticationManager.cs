namespace Domain.Services.Authorization
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password, string role);
    }
}