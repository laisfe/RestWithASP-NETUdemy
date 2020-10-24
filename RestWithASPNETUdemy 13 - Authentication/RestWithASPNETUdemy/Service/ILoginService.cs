using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Service
{
    public interface ILoginService
    {
        object FindByLogin(UserVO user);
    }
}
