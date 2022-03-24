using Japanese_C_dang_iu.Models;

namespace Japanese_C_dang_iu.Services
{
  public class UserService : IUserService
  {
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
      _context = context;
      // AddUser("anhminh2122000.gmail.com", "Asd12345");
      // AddUser("chieuthuymaijenny.gmail.com", "123456");
      // AddUser("tandt.gmail.com", "123456");
      // AddUser("thuydung2402.gmail.com", "123456");
    }

    public User? GetUserByEmailAndPassword(string email, string password)
    {
      return _context.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
    }

    public User AddUser(string email, string password)
    {
      User newUser = new User();
      newUser.Email = email;
      newUser.Password = password;
      _context.Users.Add(newUser);
      _context.SaveChanges();

      return newUser;
    }
  }
}