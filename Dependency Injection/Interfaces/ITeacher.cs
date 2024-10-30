namespace Dependency_Injection.Interfaces
{
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}
