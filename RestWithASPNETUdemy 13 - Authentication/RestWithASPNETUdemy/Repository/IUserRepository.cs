using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Service
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}
