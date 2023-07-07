using System.Collections.Generic;

namespace WiredBrainApp {
    public class EmployeeRespository {

        private readonly List<Employee> _employees = new List<Employee>();

        public void Add(Employee employee){
            _employees.Add(employee);
        }

        public void Save(){
            foreach( var employee in _employees){
                System.Console.WriteLine(employee);
            }
        }

    }
}