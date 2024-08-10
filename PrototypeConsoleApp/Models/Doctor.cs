using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrototypeConsoleApp.Models
{
    /// <summary>
    /// Базовый класс доктора
    /// </summary>
    public abstract class Doctor
    {
        /// <summary>
        /// Перс.данные
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Дата начала трудовой деятельности
        /// </summary>
        public DateTime StartEmployment { get; set; }
        protected Doctor(Person person, DateTime start)
        {
            Person = person;
            StartEmployment = start;
        }
        public virtual void StartReception(Person patient)
        {
            Console.WriteLine($"{Person.LastName} {Person.FirstName} со стажем {CalculateWorkExperience()} начал прием {patient.LastName} {patient.FirstName}".Trim());
        }

        /// <summary>
        /// Расчет стажа
        /// </summary>
        /// <returns></returns>
        public virtual string CalculateWorkExperience()
        {
            var difference = DateTime.Now.Subtract(StartEmployment);
            int years = (int)(difference.TotalDays / 365.25);
            return years > 0 ? years.ToString() + " лет" : " менее года";
        }
    }
}
