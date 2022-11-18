using PersonnelManagementAPI.Core.DataAccess;
using PersonnelManagementAPI.Core.ResourceParameter;
using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.DataAccess.Abstract;

public interface IInvoiceRepository : IBaseRepository<Invoice, InvoiceModify, InvoiceRP>
{
    
}