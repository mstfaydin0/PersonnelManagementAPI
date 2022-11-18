using PersonnelManagementAPI.Core.Models.Concrete;

namespace PersonnelManagementAPI.Core.DataAccess;

public interface IBaseRepository<T, TModify, TRP>
{
    PagedList<T> GetAll(TRP parameter);
    T GetByID(Guid id);
    Guid Add(TModify item);
    int Remove(Guid id, bool isHardDelete);
    int Update(TModify item);
    Guid CheckItemIsDuplicate(string columnName, object value, bool isCheckFoundationId);
    void SetDefaultValues(string lang, Guid userId, Guid foundationId);
}