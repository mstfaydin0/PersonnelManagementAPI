using PersonnelManagementAPI.Business.Abstract;
using PersonnelManagementAPI.DataAccess.Abstract;
using PersonnelManagementAPI.Models.Concrete;

namespace PersonnelManagementAPI.Business.Concrete;

public class InvoiceManager : IInvoiceService
{
    private readonly IInvoiceRepository _invoiceRepository;

    public InvoiceManager(IInvoiceRepository invoiceRepository)
    {
        _invoiceRepository = invoiceRepository;
    }

    public Invoice GetInvoice(Guid id)
    {
        return _invoiceRepository.GetByID(id);
    }
}