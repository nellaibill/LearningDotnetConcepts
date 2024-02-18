using Auth_DB_EFCore_Reg_Login.Models;

namespace Auth_DB_EFCore_Reg_Login.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            user.Id = _context.SaveChanges();
            return user;
        }

        public User  GetByEmail(string email) { 
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
