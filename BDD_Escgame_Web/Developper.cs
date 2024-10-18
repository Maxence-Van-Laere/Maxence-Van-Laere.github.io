namespace BDD_Escgame_Web
{
    class Developper : Person
    {
        private string poste_Dev;
        private DateTime dateEntree_Dev;
        private string url_Photo;

        public string Poste_Dev { get => poste_Dev; set => poste_Dev = value; }
        public DateTime DateEntree_Dev { get => dateEntree_Dev; set => dateEntree_Dev = value; }
        public string Url_Photo { get => url_Photo; set => url_Photo = value; }

        public Developper(string nom, string prenom, string poste_Dev, DateTime dateEntree_Dev, string url_Photo) : base(nom, prenom)
        {

            this.poste_Dev = poste_Dev;
            this.dateEntree_Dev = dateEntree_Dev;
            this.url_Photo = url_Photo;
        }
        public Developper(string nom, string prenom, string poste_Dev, DateTime dateEntree_Dev) : base(nom, prenom)
        {
            this.poste_Dev = poste_Dev;
            this.dateEntree_Dev = dateEntree_Dev;
        }
    }
}
    