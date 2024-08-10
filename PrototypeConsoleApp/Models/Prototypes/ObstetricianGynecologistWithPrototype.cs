using PrototypeConsoleApp.Models.Interfaces;
using ICloneable = PrototypeConsoleApp.Models.Interfaces.ICloneable;

namespace PrototypeConsoleApp.Models.Prototypes
{
    public class ObstetricianGynecologistWithPrototype : ObstetricianGynecologist, IMyCloneable<ObstetricianGynecologistWithPrototype>, ICloneable
    {
        public ObstetricianGynecologistWithPrototype(Person person, DateTime start) : base(person, start) { }

        public ObstetricianGynecologistWithPrototype Clone() => new ObstetricianGynecologistWithPrototype(Person, StartEmployment);

        object ICloneable.Clone() => Clone();
    }
}
