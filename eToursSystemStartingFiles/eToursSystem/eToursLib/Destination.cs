using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToursLib
{
    public class Destination
    {
        //TODO: Activity 1 place your code here

        // data members
        private string _Location;
        private DateTime _VisitDate;

        //properties
        public string Location
        {
            get => _Location;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Location), "Location is required.");
                value = value.Trim();
                if (value == "")
                    throw new ArgumentException("Location cannot be empty or whitespace.", nameof(Location));
                _Location = value;
            }
        }

        public DateTime VisitDate
        {
            get => _VisitDate;
            set
            {
                if (value < DateTime.Today)
                    throw new ArgumentException("VisitDate must be today or in the future.", nameof(VisitDate));
                _VisitDate = value;
            }
        }

        //contructor
        public Destination(string location, DateTime visitDate)
        {
            Location = location;
            VisitDate = visitDate;
        }



        //methods
        public override string ToString()
        {
            return $"{Location},{VisitDate:MMM dd yyyy}";
        }


    }
}
