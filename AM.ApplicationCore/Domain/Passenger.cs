using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        //[MinLength(3, ErrorMessage = "invalide min length")]
        //[MaxLength(25,ErrorMessage = "invalide max length")]
        //public string FirstName { get; set; }
        ////public int Id { get; set; }

        //public string LastName { get; set; }
        public FullName FullName { get; set; }

        [Display(Name ="date of birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number!")]
        public int? TelNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        public  IList<Flight> Flights { get; set; }
        public IList<ReservationTicket> ReservationsTickets { get; set; }

        //public override string ToString()
        //{
        //    return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        //}

        //poly par signature 
        public bool CheckProfile (string firstName , string lastName)
        {
            return FullName.FirstName == firstName && FullName.LastName == lastName;  

        }

        public bool CheckProfile(string firstName , string lastName,string email)
        {
            return FullName.FirstName == firstName && FullName.LastName == lastName && EmailAddress == email;    
        }

        public bool login(string firstName, string lastName, string email = null)
        {
           if(email != null)
            return FullName.FirstName == firstName && FullName.LastName == lastName && EmailAddress == email;
            return FullName.FirstName == firstName && FullName.LastName == lastName;
        }

        //public bool login1(string firstName, string lastName, string email = null)
        //{
        //    if (email != null)
        //        return CheckProfile(firstName, lastName, email);
        //    return FullName.FirstName == firstName && FullName.LastName == LastName;
        //}

        //poly par héritage 
        public virtual void PassengerType()
        {

            Console.WriteLine("I'Passenger");
        }

    }
}
