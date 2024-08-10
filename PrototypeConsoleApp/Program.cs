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

            var clonedDental = dentalSurgeon.Clone();
            var clonedGynecologist = obstetricianGynecologist.Clone();

            Console.WriteLine($"Базовый Стоматолог-хирург: {dentalSurgeon.Person.LastName} {dentalSurgeon.Person.FirstName}");
            Console.WriteLine($"Клон Стоматолога-хирурга: {clonedDental.Person.LastName} {clonedDental.Person.FirstName}");

            Console.WriteLine($"Базовый Гениколог:{obstetricianGynecologist.Person.LastName} {obstetricianGynecologist.Person.FirstName}");
            Console.WriteLine($"Клон Гениколога:{clonedGynecologist.Person.LastName} {clonedGynecologist.Person.FirstName}");

            dentalSurgeon.StartReception(patient);
            obstetricianGynecologist.StartReception(patient);
            clonedDental.StartReception(patient);
            clonedGynecologist.StartReception(patient);

            Console.ReadKey();
        }
    }
}
