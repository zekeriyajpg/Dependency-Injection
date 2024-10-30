using Dependency_Injection.Interfaces;

namespace Dependency_Injection.Controllers.Models
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
