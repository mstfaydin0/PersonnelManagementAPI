namespace PersonnelManagementAPI.Core.Models.Concrete;

public class Person
{
    public Person()
    {
        PhoneNumber = new List<String>();
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string IdNumber { get; set; }
    // public IEnumerable<DetailStructure> Details { get; set; }
    // public IEnumerable<DetailStructureSummary> DetailSummary { get; set; }
    // public IdName Foundation { get; set; }
    // public AddressModel AddressDetail { get; set; }
    public IEnumerable<string> PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    // public HashSet<IdName> Languages { get; set; }
    // public HashSet<IdName> Nationalities { get; set; }
    // public IEnumerable<DocInfo> DocInfos { get; set; }
    // public IdName Sex { get; set; }
    // public IdName Country { get; set; }

}

public class PersonModify : BaseModifyModel
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string IdNumber { get; set; }
    // public IEnumerable<DetailStructure> Details { get; set; }
    // public IEnumerable<DetailStructureSummary> DetailSummary { get; set; }
    // public AddressModel AddressDetail { get; set; }
    public IEnumerable<string> PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public IEnumerable<Guid> LanguageIds { get; set; }
    public IEnumerable<Guid> NationalityIds { get; set; }
    public Guid SexId { get; set; }
}