using Dependency_Injection.Controllers.Models;
using Dependency_Injection.Interfaces;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // 1. Dependency Injection i�in ServiceCollection olu�turuyoruz.
        var serviceProvider = new ServiceCollection()
            // 2. ITeacher aray�z�ne kar��l�k gelen Teacher s�n�f�n� DI konteynerine ekliyoruz.
            .AddTransient<ITeacher>(provider => new Teacher("Ali", "Y�lmaz"))
            // 3. ClassRoom s�n�f�n� DI konteynerine ekliyoruz.
            .AddTransient<ClassRoom>()
            .BuildServiceProvider();

        // 4. DI konteynerinden ClassRoom nesnesini al�yoruz (Ba��ml�l�klar enjekte ediliyor).
        var classRoom = serviceProvider.GetService<ClassRoom>();

        // 5. ��retmenin bilgilerini ekrana yazd�r�yoruz.
        if (classRoom != null)
        {
            Console.WriteLine(classRoom.GetTeacherInfo());
        }
        else
        {
            Console.WriteLine("ClassRoom instance couldn't be created.");
        }
    }
}
