using PersonnelManagementAPI.Core.Models.Concrete;

namespace PersonnelManagementAPI.Models.Concrete;

public class User : Person
{
    public string Username { get; set; }
    public bool? IsActive { get; set; }
    public string AppLang { get; set; }
    public IEnumerable<string> Permissions { get; set; }
    public IEnumerable<string> Roles { get; set; }
    public string Image { get; set; }
    public string Password { get; set; }
    public string PasswordHash { get; set; }
    // public IdName Type { get; set; }
    // public IdName FoundationSub { get; set; }
    public bool? IsManager { get; set; }
}

public class UserModify : PersonModify
{
    public string Username { get; set; }
    public bool? IsActive { get; set; }
    public string AppLang { get; set; }
    public IEnumerable<string> Permissions { get; set; }
    public IEnumerable<string> Roles { get; set; }
    public string Image { get; set; }
    public string Password { get; set; }
    public string PasswordHash { get; set; }
    public Guid FoundationId { get; set; }
    public Guid FoundationSubId { get; set; }
    public Guid TypeId { get; set; }
    public bool? IsManager { get; set; }
}