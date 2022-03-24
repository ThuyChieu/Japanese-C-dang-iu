using Japanese_C_dang_iu.Models;

namespace Japanese_C_dang_iu.Services
{
  public interface IUserService
  {
    User? GetUserByEmailAndPassword(string email, string password);

    User AddUser(string email, string password);
  }
}