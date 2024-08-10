using PrototypeConsoleApp.Models;
using PrototypeConsoleApp.Models.Prototypes;

namespace PrototypeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patient = new Person("Иванов", "Иван");

            var dentalSurgeon = new DentalSurgeonWithPrototype(new Person("Петров", "Петр"), new DateTime(2020, 1, 1));
            var obstetricianGynecologist = new ObstetricianGynecologistWithPrototype(new Person("Сидоров", "Михаил"), new DateTime(2010, 1, 1));

            var clonedDog = dentalSurgeon.Clone();
            var clonedParrot = obstetricianGynecologist.Clone();

            Console.WriteLine($"Original DentalSurgeon: {dentalSurgeon.Person.LastName} {dentalSurgeon.Person.FirstName}");
            Console.WriteLine($"Cloned DentalSurgeon: {clonedDog.Person.LastName} {clonedDog.Person.FirstName}");

            Console.WriteLine($"Original ObstetricianGynecologist:{obstetricianGynecologist.Person.LastName} {obstetricianGynecologist.Person.FirstName}");
            Console.WriteLine($"Cloned ObstetricianGynecologist:{clonedParrot.Person.LastName} {clonedParrot.Person.FirstName}");

            dentalSurgeon.StartReception(patient);
            obstetricianGynecologist.StartReception(patient);
            clonedDog.StartReception(patient);
            clonedParrot.StartReception(patient);

            Console.ReadKey();
        }
    }
}
