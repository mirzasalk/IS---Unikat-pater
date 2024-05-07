using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci_IS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Korisnik pristupa singleton instanci UserManagera
            UserManager userManager = UserManager.Instance;

            // Dodavanje novih korisnika
            userManager.AddUser("john_doe", "password123");
            userManager.AddUser("jane_doe", "abc456");

            // Validacija korisničkog naloga
            string username = "john_doe";
            string password = "password123";
            bool isValid = userManager.ValidateUser(username, password);

            if (isValid)
            {
                Console.WriteLine($"Korisnik {username} je uspešno prijavljen.");
            }
            else
            {
                Console.WriteLine($"Pogrešno korisničko ime ili lozinka za korisnika {username}.");
            }

            // Prikaz informacija o korisniku
            string usernameToFind = "jane_doe";
            User user = userManager.GetUser(usernameToFind);
            if (user != null)
            {
                Console.WriteLine($"Korisnik: {user.Username}, Lozinka: {user.Password}");
            }
            else
            {
                Console.WriteLine($"Korisnik sa korisničkim imenom {usernameToFind} nije pronađen.");
            }
            UserManager userManager2 = UserManager.Instance;
            Console.WriteLine(userManager == userManager2);
            Console.ReadLine();
        }
    }

}
