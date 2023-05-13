using Data.Entities;

namespace Data.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        List<User> GetUserWithRelations();
    }
}