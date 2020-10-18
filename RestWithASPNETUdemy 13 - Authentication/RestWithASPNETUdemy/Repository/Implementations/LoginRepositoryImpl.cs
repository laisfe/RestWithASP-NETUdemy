using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System.Linq;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public class LoginRepositoryImpl : ILoginRepository
    {

        private readonly MySQLContext _context;

        public LoginRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Login.Equals(login));
        }
    }
}
