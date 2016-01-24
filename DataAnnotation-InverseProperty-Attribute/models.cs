using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotation_InverseProperty_Attribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        //Navigational property
        public Department Department { get; set; }
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        //Navigational property
        public virtual ICollection<Employee> Employees { get; set; }
    }


    public class Flight
    {
        public int FlightID { get; set; }
        public string Name { get; set; }

        
        public Airport DepartureAirport { get; set; }

     
        public Airport ArrivalAirport { get; set; }
    }


    public class Airport
    {
        public int AirportID { get; set; }
        public string Name { get; set; }
        [InverseProperty("DepartureAirport")]
        public virtual ICollection<Flight> DepartingFlights { get; set; }
        [InverseProperty("ArrivalAirport")]
        public virtual ICollection<Flight> ArrivingFlights { get; set; }
    }


}
