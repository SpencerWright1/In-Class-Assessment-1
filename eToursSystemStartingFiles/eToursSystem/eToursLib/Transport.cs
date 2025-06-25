using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToursLib
{
    public class Transport
    {
        //TODO: Activity 2 place your code here

        // data members
        private string _Name;
        private int _Capacity;

        //properties
        public string Name
        {
            get => _Name;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Name), "Name is required.");
                value = value.Trim();
                if (value == "")
                    throw new ArgumentException("Name cannot be empty or whitespace.", nameof(Name));
                _Name = value;
            }
        }

        public int Capacity
        {
            get => _Capacity;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Capacity must be a positive number. You entered: {value}", nameof(Capacity));
                _Capacity = value;
            }
        }
        //methods
        public override string ToString()
        {
            return $"{Name},{Capacity}";
        }
        //contructor
        public Transport(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}
