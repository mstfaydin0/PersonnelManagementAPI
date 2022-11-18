using System.Data;
using Dapper;
using PersonnelManagementAPI.Core.Models.Concrete;
using PersonnelManagementAPI.Core.ResourceParameter;
using PersonnelManagementAPI.DataAccess.Abstract;
using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.DataAccess.Concrete;

public class InvoiceRepository : BaseRepository, IInvoiceRepository
{
    public InvoiceRepository(
        IDbConnection db,
        // IMemoryCache memoryCache,
        ILoggerFactory loggerFactory
    ) : base(db, loggerFactory, "user_record")
    {
    }

    public PagedList<Invoice> GetAll(InvoiceRP parameter)
    {
        throw new NotImplementedException();
    }

    public Invoice GetByID(Guid id)
    {
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.Add("@id", id);
        var query = "SELECT * FROM invoice WHERE id = @id AND isdeleted = false";
        return Db.QueryFirstOrDefault<Invoice>(query, dynamicParameters);
    }

    public Guid Add(InvoiceModify item)
    {
        throw new NotImplementedException();
    }

    public int Remove(Guid id, bool isHardDelete)
    {
        throw new NotImplementedException();
    }

    public int Update(InvoiceModify item)
    {
        throw new NotImplementedException();
    }
}