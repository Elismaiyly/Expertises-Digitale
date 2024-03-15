using System.ComponentModel;

namespace CV_PFA.Models
{
    public class AuthentificationRecruteur
    {
        public int Id { get; set; }
        
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string tele { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirmationpassword { get; set; }
        public string nomentreprise { get; set; }
        public string NRmatricul { get; set; }
        public string piecejoint { get; set; }
    }
}
