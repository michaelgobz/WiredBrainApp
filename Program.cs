// See https://aka.ms/new-console-template for more information

using System;
using WiredBrainApp.Repositories;
using WiredBrainApp.entities;
using WiredBrainApp.Dbcontext;

namespace WiredBrainApp.entities
{
    public static class Program
    {

        public static void Main(string[] args)
        {

            // repositories

            SqlRespository<Employee> employees = new SqlRespository<Employee>(new DbStorageContext());
            SqlRespository<Organisation> organisations = new SqlRespository<Organisation>(new DbStorageContext());
            SetEmployees(employees);
            SetOrganisations(organisations);
            WriteToConsole(employees);
            WriteToConsole(organisations);

            System.Console.ReadLine();
        }

        private static void WriteToConsole(IReadRepository<IEntity> repository)
        {
            IEnumerable<IEntity>? list = repository.GetAll();
            if(list != null) {
                foreach (var item in list){
                System.Console.WriteLine(item);
                }
            } else {
                System.Console.WriteLine($"You don't have anything in there");
            }
            
        }

        private static void SetEmployees(IRepository<Employee> repository)
        {

            // employees 
            Employee michael = new Employee("Michael", "Goboola");
            Employee nicole = new Employee("Nicole", "Aisha");
            Employee moureen = new Employee("Moureen", "Ashaba");
            Employee drake = new Employee("Drake", "Akandwanaho");
            Employee moon = new Employee("Marvin", "Moon");

            /**

            repository.Add(new Employee { FirstName = "Michael", LastName = "Goboola" });
            repository.Add(new Employee { FirstName = "Nicole", LastName = "Aisha" });
            repository.Add(new Employee { FirstName = "Moureen", LastName = "Ashaba" });
            repository.Add(new Employee { FirstName = "Drake", LastName = "Akandwanaho" });
            repository.Add(new Employee { FirstName = "Marvin", LastName = "Moon" });

            */

            repository.Add(michael);
            repository.Add(nicole);
            repository.Add(moureen);
            repository.Add(drake);
            repository.Add(moon);
            repository.Save();
        }

        private static void SetOrganisations(IRepository<Organisation> repository)
        {
            var bck = new Organisation("Bishop Cipriano Kihangire", "Education");
            var motors = new Organisation("Kiira motors", "Automotive");
            
            //using the object constructor
            /**
            repository.Add(new Organisation { Name = "Bishop Cipriano Kihangire", Domain = "Education" });
            repository.Add(new Organisation { Name = "Kiira motors", Domain = "Automotive" });
            */

            repository.Add(bck);
            repository.Add(motors);
            repository.Save();
        }
    }
}
