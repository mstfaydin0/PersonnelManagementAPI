using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.Business.Abstract;

public interface IInvoiceService
{
    public Invoice GetInvoice(Guid id);
}