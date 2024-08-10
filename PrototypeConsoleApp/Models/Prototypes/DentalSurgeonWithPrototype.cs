using PrototypeConsoleApp.Models.Interfaces;
using ICloneable = PrototypeConsoleApp.Models.Interfaces.ICloneable;

namespace PrototypeConsoleApp.Models.Prototypes
{
    // 2. Реализация прототипа для классов
    public class DentalSurgeonWithPrototype : DentalSurgeon, IMyCloneable<DentalSurgeonWithPrototype>, ICloneable
    {
        public DentalSurgeonWithPrototype(Person person, DateTime start) : base(person, start) { }

        public DentalSurgeonWithPrototype Clone() => new DentalSurgeonWithPrototype(Person, StartEmployment);

        object ICloneable.Clone() => Clone();
    }
}
