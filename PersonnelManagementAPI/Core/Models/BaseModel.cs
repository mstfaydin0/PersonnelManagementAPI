namespace PersonnelManagementAPI.Core.Models;

public class BaseModel
{
    public Guid Id { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid Muserid { get; set; }
    public bool IsDeleted { get; set; }
    public string Description { get; set; }
}

public class BaseModifyModel : BaseModel
{
}