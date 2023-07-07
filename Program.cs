// See https://aka.ms/new-console-template for more information

using System ;

namespace WiredBrainApp
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
            EmployeeRespository respository =  new EmployeeRespository();

             // employees 
            Employee michael = new Employee("Michael" , "Goboola");
            Employee nicole = new Employee("Nicole","Aisha");
            Employee moureen = new Employee("Moureen","Ashaba");
            Employee drake = new Employee("Drake","Akandwanaho");
            Employee moon = new Employee("Marvin","Moon");

            respository.Add(michael);
            respository.Add(nicole);
            respository.Add(moureen);
            respository.Add(drake);
            respository.Add(moon);
            respository.Save();

            System.Console.ReadLine();
        }

    }
}

