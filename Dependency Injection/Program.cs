using Dependency_Injection.Controllers.Models;
using Dependency_Injection.Interfaces;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // 1. Dependency Injection için ServiceCollection oluþturuyoruz.
        var serviceProvider = new ServiceCollection()
            // 2. ITeacher arayüzüne karþýlýk gelen Teacher sýnýfýný DI konteynerine ekliyoruz.
            .AddTransient<ITeacher>(provider => new Teacher("Ali", "Yýlmaz"))
            // 3. ClassRoom sýnýfýný DI konteynerine ekliyoruz.
            .AddTransient<ClassRoom>()
            .BuildServiceProvider();

        // 4. DI konteynerinden ClassRoom nesnesini alýyoruz (Baðýmlýlýklar enjekte ediliyor).
        var classRoom = serviceProvider.GetService<ClassRoom>();

        // 5. Öðretmenin bilgilerini ekrana yazdýrýyoruz.
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
