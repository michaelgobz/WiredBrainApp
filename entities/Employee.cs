using System;

namespace WiredBrainApp
{
    public class Employee {
        public int Id {
            get {
                return Id;
            }
        }

        public string FirstName {
            get{
                return FirstName;

            }
            set{
                FirstName = value;
            }
        }

        public string LastName {
            get{
                return LastName;
            }
            set {
                LastName = value;
            }
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