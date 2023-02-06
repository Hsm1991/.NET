using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PasseportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> flights { get; set; }
        public override string ToString()
        {
            return this.BirthDate + " " + this.PasseportNumber + " " + this.EmailAdress + " " + this.FirstName + " " + this.LastName + " " + this.TelNumber + " " + this.flights;
        }
        //public bool CheckProfile(string first_name, string last_name)
        //{

        //    return first_name == FirstName && last_name == LastName;
        //}
        //public bool CheckProfile(string first_name, string last_name, string mail)
        //{
        //    return first_name == FirstName && last_name == LastName && mail == EmailAdress;
        //}
        public bool CheckProfile(string first_name, string last_name, string mail= null)
        {   if (mail != null){ 
            return first_name == FirstName && last_name == LastName && mail == EmailAdress;
            }
        else
            {
                return first_name == FirstName && last_name == LastName;
            }
        }

        public virtual void PassengerType() 
        {
            Console.WriteLine("I'm a passenger");
        }

    }
}
