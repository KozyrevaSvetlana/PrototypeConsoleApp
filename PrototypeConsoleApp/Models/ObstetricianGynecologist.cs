namespace PrototypeConsoleApp.Models
{
    /// <summary>
    /// Окушер-гинеколог
    /// </summary>
    public class ObstetricianGynecologist : Gynecologist
    {
        public ObstetricianGynecologist(Person person, DateTime start) : base(person, start) { }

        // Метод для клонирования попугая
        public ObstetricianGynecologist Clone()
        {
            return new ObstetricianGynecologist(Person, StartEmployment);
        }
    }
}
