using System;

namespace WiredBrainApp.entities
{
    public class Organisation :IEntity 
    {
        public int Id {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public string? Description {
            get;
            set;
        }

        public string? location {
            get;
            set;
        }

        public string Domain {
            get;
            set;
        }

        public Organisation(string Name , string Domain){
            this.Name= Name;
            this.Domain = Domain;

        }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name} Domain: {Domain}";
        }

    }
}