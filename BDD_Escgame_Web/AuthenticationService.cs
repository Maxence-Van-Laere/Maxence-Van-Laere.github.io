namespace BDD_Escgame_Web
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> Login(string username, string password)
        {
            // Remplace cette logique par une validation avec ta base de données ou un système d'authentification réel.
            if (username == "admin" && password == "password")
            {
                // Simuler une connexion réussie
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        public async Task Logout()
        {
            // Logique de déconnexion ici
            await Task.CompletedTask;
        }

    }
}
