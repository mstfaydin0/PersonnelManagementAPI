using System.Data;
using Dapper;
using Microsoft.Extensions.Caching.Memory;
using PersonnelManagementAPI.Core.Models.Concrete;
using PersonnelManagementAPI.Core.ResourceParameter;
using PersonnelManagementAPI.DataAccess.Abstract;
using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.DataAccess.Concrete;

public class UserRepository : BaseRepository, IUserRepository
{
    // IMemoryCache _memoryCache;

    public UserRepository(
        IDbConnection db,
        // IMemoryCache memoryCache,
        ILoggerFactory loggerFactory
    ) : base(db,loggerFactory,"user_record")
    {}
    
    public PagedList<User> GetAll(UserRP parameter)
    {
        throw new NotImplementedException();
    }

    public User GetByID(Guid id)
    {
        var sql = $"SELECT * FROM {TableName} WHERE id = @id";
        return Db.QueryFirstOrDefault<User>(sql, new { id });
    }

    public Guid Add(UserModify item)
    {
        throw new NotImplementedException();
    }

    public int Remove(Guid id, bool isHardDelete)
    {
        throw new NotImplementedException();
    }

    public int Update(UserModify item)
    {
        throw new NotImplementedException();
    }
}