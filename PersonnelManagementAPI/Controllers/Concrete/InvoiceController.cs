using Microsoft.AspNetCore.Mvc;
using PersonnelManagementAPI.Business.Abstract;

namespace PersonnelManagementAPI.Controllers.Concrete;

[ApiController]
[Route("invoice")]
public class InvoiceController : ControllerBase
{
    private readonly IInvoiceService _invoiceService;
    
    public InvoiceController(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var invoice = _invoiceService.GetInvoice(id);
        return Ok(invoice);
    }
}