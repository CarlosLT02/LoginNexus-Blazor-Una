using loginNexus.Models;


namespace loginNexus.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "professor@nexus.paiva", Password = "123", Role = "Professor", Name = "Paiva" },
        new User { Email = "aluno@nexus.carlos", Password = "123", Role = "Student", Name = "Carlos" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}