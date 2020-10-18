using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface ILoginRepository
    {
        User FindByLogin(string login);
    }
}
