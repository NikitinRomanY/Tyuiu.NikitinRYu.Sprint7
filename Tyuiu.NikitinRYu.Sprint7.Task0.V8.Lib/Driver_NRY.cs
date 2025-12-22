using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib
{
    public class Driver_NRY
    {
        public int Id { get; set; }
        public string LastName { get; set; }              // Фамилия
        public string FirstName { get; set; }             // Имя
        public string MiddleName { get; set; }            // Отчество
        public DateTime BirthDate { get; set; }           // Дата рождения
        public int Experience { get; set; }               // Стаж работы (лет)
        public decimal Salary { get; set; }               // Оклад (руб)

        public string FullName => $"{LastName} {FirstName} {MiddleName}";

        public override string ToString()
        {
            return FullName;
        }
    }
}
