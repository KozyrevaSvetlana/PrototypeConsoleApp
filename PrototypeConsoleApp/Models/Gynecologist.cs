namespace PrototypeConsoleApp.Models
{
    /// <summary>
    /// Гинеколог
    /// </summary>
    public class Gynecologist : Doctor
    {
        public Gynecologist(Person person, DateTime start) : base(person, start) { }
    }
}
