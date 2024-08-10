namespace PrototypeConsoleApp.Models
{
    /// <summary>
    /// Пациент
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get;}
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; }
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
