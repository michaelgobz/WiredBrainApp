// See https://aka.ms/new-console-template for more information

using System ;
using WiredBrainApp.Repositories;
using WiredBrainApp.entities;

namespace WiredBrainApp.entities
{
    public static class Program {

        public static void Main (string[] args)
        {
            
            // repositories

            ListRespository<Employee> employees = new ListRespository<Employee>();
            ListRespository<Organisation> organisations = new ListRespository<Organisation>();
            SetEmployees(employees);
            SetOrganisations(organisations);

            System.Console.ReadLine();
        }

        private static void SetEmployees(IRepository<Employee> repository)
        {

            // employees 
            Employee michael = new Employee("Michael", "Goboola");
            Employee nicole = new Employee("Nicole", "Aisha");
            Employee moureen = new Employee("Moureen", "Ashaba");
            Employee drake = new Employee("Drake", "Akandwanaho");
            Employee moon = new Employee("Marvin", "Moon");

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
            repository.Add(bck);
            repository.Add(motors);
            repository.Save();
        }
    }
}

