using System.Data;
using Dapper;

namespace PersonnelManagementAPI.DataAccess.Abstract;

public abstract class BaseRepository
{
    protected IDbConnection Db { get; }
    protected ILogger Logger { get; }
    protected string TableName { get; }
    protected string Lang { get; set; }
    protected Guid UserId { get; set; }
    protected Guid UserFoundationId { get; set; }

    // protected IAidMemoryItems _aidMemoryItems;

    protected BaseRepository(IDbConnection db, ILoggerFactory loggerFactory, string tableName)
    {
        Db = db;
        Logger = loggerFactory?.CreateLogger("BaseRepository");
        TableName = tableName;
    }


    // protected BaseRepository(IDbConnection db, ILoggerFactory loggerFactory, string tableName
    //     // IAidMemoryItems aidMemoryItems
    // )
    // {
    //     Db = db;
    //     Logger = loggerFactory?.CreateLogger("BaseRepository");
    //     TableName = tableName;
    //     // _aidMemoryItems = aidMemoryItems;
    // }
    public void SetDefaultValues(string lang, Guid userId, Guid foundationId)
    {
        Lang = lang;
        UserId = userId;
        UserFoundationId = foundationId;
    }

    public Guid CheckItemIsDuplicate(string columnName, object value, bool isCheckFoundationId)
    {
        if (isCheckFoundationId)
        {
            var query = " SELECT  Id FROM " + TableName + " WHERE " + columnName +
                        " = @value AND foundationId= @UserFoundationId";
            return Db.ExecuteScalar<Guid>(query, new { value, UserFoundationId });
        }
        else
        {
            var query = " SELECT  Id FROM " + TableName + " WHERE " + columnName + " = @value ";
            return Db.ExecuteScalar<Guid>(query, new { value });
        }
    }

    public Guid CheckItemIsDuplicate(string columnName, object value, string columnName2, object value2)
    {
        var query = " SELECT  Id FROM " + TableName + " WHERE " + columnName + " = @value AND  " + columnName2 +
                    " = @value2";
        return Db.ExecuteScalar<Guid>(query, new { value, value2 });
    }
}