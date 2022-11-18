using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.Business.Abstract;

public interface IUserService
{
    public User GetUser(Guid id);
}