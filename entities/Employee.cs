using System;

namespace WiredBrainApp
{
    public class Employee {
        public int ID {
            get;
            set {

            }
        }

        public string FirstName {
            get;
            set{

            }
        }

        public string LastName {
            get;
            set {

            }
        }

        public Employee(string firstname , string lastname){
            ID =  firstname.Length * lastname.Length;
            FirstName = firstname;
            LastName = lastname;

        }

        public override string ToString()
        {
            return $"ID: {ID} FirstName {FirstName} LastName {LastName}";
        }


    }


    
}