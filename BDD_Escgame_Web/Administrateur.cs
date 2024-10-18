namespace BDD_Escgame_Web
{
    class Administrateur : Person
    {
        private string id;
        private string password;

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }

        public Administrateur(string nom, string prenom, string _id, string _password) : base(nom, prenom)
        {
            this.id = _id;
            this.password= _password;
        }
    }

}
