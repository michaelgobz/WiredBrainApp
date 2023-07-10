using System;

namespace WiredBrainApp
{
    public class Organisation {
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

        public Organisation(string name , string domain){
            Name = name;
            Domain = domain;

        }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name} Domain: {Domain}";
        }

    }
}