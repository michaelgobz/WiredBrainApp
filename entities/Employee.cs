using System;

namespace WiredBrainApp
{
    public class Employee {
        public int Id {
            get;
            set;
        }

        public string FirstName {
            get;
            set;
        }

        public string LastName {
            get;
            set;
        }

        public Employee(string firstname , string lastname){
            FirstName = firstname;
            LastName = lastname;

        }

        public override string ToString()
        {
            return $"ID: {Id} FirstName {FirstName} LastName {LastName}";
        }

    }
}