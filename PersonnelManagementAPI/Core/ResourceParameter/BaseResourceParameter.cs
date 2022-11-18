namespace PersonnelManagementAPI.Core.ResourceParameter;

public class BaseResourceParameter
{
    public bool IsGetAll { get; set; }
    public Guid Id { get; set; }

    private const int minPageNumber = 1;

    private int _pageNumber = 1;

    public int PageNumber
    {
        get => _pageNumber;
        set => _pageNumber = value < minPageNumber ? 1 : value;
    }

    private const int maxPageSize = 1000;
    private int _pageSize = 10;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > maxPageSize) ? maxPageSize : (value < 0) ? 10 : value;
    }
}

public class UserRP : BaseResourceParameter
{
    public string Name { get; set; }
    public string IdNumber { get; set; }
    public string Username { get; set; }
    public Guid CountryId { get; set; }
    public Guid CityId { get; set; }
    public IEnumerable<Guid> TypeId { get; set; }
    public Guid FoundationId { get; set; }
    public bool? IsActive { get; set; }
    public string Permission { get; set; }
}