namespace BDD_Escgame_Web
{
    public interface IAuthenticationService
    {
        Task<bool> Login(string username, string password);
        Task Logout();
    }
}
