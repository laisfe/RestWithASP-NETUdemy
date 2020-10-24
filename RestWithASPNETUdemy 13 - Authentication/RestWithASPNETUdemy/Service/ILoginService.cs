using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Service
{
    public interface ILoginService
    {
        object FindByLogin(User user);
    }
}
