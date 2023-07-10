// See https://aka.ms/new-console-template for more information

using System ;

namespace WiredBrainApp.entities
{
    public static class Program {

        public static void Main (string[] args)
        {
            var utils = new Utils();
            /**
            utils.StackDoubles();
            utils.StackStrings();
            **/


            // repository
            SetEmployees();

            // organisations

            SetOrganisations();

            System.Console.ReadLine();
        }

        private static void SetEmployees()
        {
            ListRespository<Employee> employees = new ListRespository<Employee>();

            // employees 
            Employee michael = new Employee("Michael", "Goboola");
            Employee nicole = new Employee("Nicole", "Aisha");
            Employee moureen = new Employee("Moureen", "Ashaba");
            Employee drake = new Employee("Drake", "Akandwanaho");
            Employee moon = new Employee("Marvin", "Moon");

            employees.Add(michael);
            employees.Add(nicole);
            employees.Add(moureen);
            employees.Add(drake);
            employees.Add(moon);
            employees.Save();
        }

        private static void SetOrganisations()
        {
            ListRespository<Organisation> organisations = new ListRespository<Organisation>();
            var bck = new Organisation("Bishop Cipriano Kihangire", "Education");
            var motors = new Organisation("Kiira motors", "Automotive");
            organisations.Add(bck);
            organisations.Add(motors);
            organisations.Save();
        }
    }
}

