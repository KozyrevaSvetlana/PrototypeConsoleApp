namespace PrototypeConsoleApp.Models
{
    /// <summary>
    /// Стоматолог
    /// </summary>
    public class Dentist : Doctor
    {
        public Dentist(Person person, DateTime start) : base(person, start) { }
    }
}
