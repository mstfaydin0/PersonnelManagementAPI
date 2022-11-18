using PersonnelManagementAPI.Business.Abstract;
using PersonnelManagementAPI.DataAccess.Abstract;
using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.Business.Concrete;

public class UserManager:IUserService
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public User GetUser(Guid id)
    {
       return _userRepository.GetByID(id);
    }
}