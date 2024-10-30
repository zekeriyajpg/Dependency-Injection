using Dependency_Injection.Interfaces;

namespace Dependency_Injection.Controllers.Models
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"Öğretmen: {FirstName} {LastName}";
        }
    }
}
