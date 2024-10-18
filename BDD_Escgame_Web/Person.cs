namespace BDD_Escgame_Web
{
    abstract class Person
    {
        private string nom;
        private string prenom;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Person(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

    }
}
