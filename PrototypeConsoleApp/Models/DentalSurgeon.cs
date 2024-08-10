namespace PrototypeConsoleApp.Models
{
    /// <summary>
    /// Стоматолог-хирург
    /// </summary>
    public class DentalSurgeon : Dentist
    {
        public DentalSurgeon(Person person, DateTime start) : base(person, start) { }

        /// <summary>
        /// Клонирование
        /// </summary>
        /// <returns></returns>
        public DentalSurgeon Clone()
        {
            return new DentalSurgeon(Person, StartEmployment);
        }
    }
}
