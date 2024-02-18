using Auth_DB_EFCore_Reg_Login.Models;

namespace Auth_DB_EFCore_Reg_Login.Data
{
    public interface IUserRepository
    {
        User Create(User user);

        User GetByEmail(string email);

        User GetById(int id);
    }
}
