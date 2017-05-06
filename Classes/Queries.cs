using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest.Classes
{
    public class Queries
    {
        public List<Department> Departments = new List<Department>
        {
            new Department (1, "Сбыт"),
            new Department (2, "Бухгалтерия"),
            new Department (3, "Откаты")
        };

        public List<Employee> Employees = new List<Employee>
        {
            new Employee(1, "Николай Иванов", 25, 1),
            new Employee(2, "Сергей Петров", 30, 1),
            new Employee(3, "Иван Сидоров", 28, 1),
            new Employee(4, "Марта Мартынюк", 45, 2),
            new Employee(5, "Евгения Сосиско", 34, 2), 
            new Employee(6, "Станислав Прудько", 40, 3)
        };

        public List<Car> Cars = new List<Car>
        {
            new Car(1, 2, "Жигули", "АА2345СС"),
            new Car(2, 4, "Опель", "AA1234AB"),
            new Car(3, 6, "Порш", "СТАСИК"),
            new Car(3, 6, "Феррари", "A777A")
        };

        public void Execute()
        {
            // 0. Вывести имена и возраста сотрудников отсортированных по возрасту (пример)
            var result0 = from e in Employees orderby e.Age ascending select new { e.FullName, e.Age };
            
            // 1. По каждому сотруднику вывести имя и название отдела
            
            // 2. Вывести сотрудников, у которых нет автомобиля

            // 3. Вывести названия отделов и количество сотрудников по каждому отделу

            // 4. Вывести сотрудников, у которых больше одного автомобиля

            // 5. Вывести департаменты и количество автомобилей сотрудников этого департамента

            // 6. По каждому департаменту вывести название департамента, имя и возраст самого старшего сотрудника
            
            // 7. Вывести имена сотрудников и список номеров автомобилей этого сотрудника через запятую. Если автомобиля нет, вывести пустую строку
        }
    }
}
