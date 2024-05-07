using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci_IS
{
    public class UserManager
    {
        // Privatno statičko polje za jedinstvenu instancu
        private static UserManager _instance;
        private List<User> _users = new List<User>();
        // Privatni konstruktor kako bi se sprečilo direktno instanciranje izvan klase
        private UserManager() { }

        // Statička metoda za pristup instanci
        public static UserManager Instance
        {
            get
            {
                // Ako instanca nije kreirana, kreiraj je
                if (_instance == null)
                {
                    _instance = new UserManager();
                }
                // Vrati jedinstvenu instancu
                return _instance;
            }
        }

        // Lista korisnika kao primer skladišta korisničkih naloga
        

        // Primer metoda za dodavanje novog korisnika
        public void AddUser(string username, string password)
        {
            // Implementacija dodavanja korisnika
            _users.Add(new User(username, password));
        }

        // Primer metoda za validaciju korisničkog naloga
        public bool ValidateUser(string username, string password)
        {
            // Implementacija validacije korisničkog naloga
            foreach (var user in _users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true; // Korisnik je validan
                }
            }
            return false; // Korisnik nije validan
        }

        // Primer metoda za pristup korisničkim nalozima
        public User GetUser(string username)
        {
            // Implementacija pristupa korisničkom nalogu
            foreach (var user in _users)
            {
                if (user.Username == username)
                {
                    return user; // Pronađen je korisnik sa datim korisničkim imenom
                }
            }
            return null; // Korisnik nije pronađen
        }
    }

   


}





