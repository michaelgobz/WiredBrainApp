using System;

namespace WiredBrainApp.entities
{
    public class Employee : IEntity
    {
        public int Id {
<<<<<<< HEAD
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public Employee(string firstname, string lastname)
        {
=======
            get { 
            }
        }

        public string FirstName {
            get{
                
            }
            set{
            }
        }

        public string LastName {
            get{
                
            }
            set {
            }
        }

        public Employee(string firstname , string lastname){
>>>>>>> b80436bf54048c4cc51b333ce7237fb2af660c25
            FirstName = firstname;
            LastName = lastname;

        }

        public override string ToString()
        {
            return $"ID: {Id} FirstName {FirstName} LastName {LastName}";
        }

    }
}