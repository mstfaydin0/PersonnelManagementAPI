using PersonnelManagementAPI.Core.Models;

namespace PersonnelManagementAPI.Models.Concrete;

public class Invoice : BaseModel
{
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime InvoiceCreatedDate { get; set; }
    public DateTime DueDate { get; set; }
    public float Amount { get; set; }
    public int Tax { get; set; }
    public Guid StatusId { get; set; }
}
public class InvoiceModify : BaseModifyModel
{
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public float Amount { get; set; }
    public int Tax { get; set; }
    public Guid StatusId { get; set; }
}