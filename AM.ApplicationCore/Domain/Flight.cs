using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {

        public int FlightId { get; set; }
        public string AirlineLogo { get; set; }
        [DataType(DataType.Date)]
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        [DataType(DataType.Date)]
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

     
        public  IList<Passenger> Passengers { get; set; }
        [ForeignKey("PlaneFK")]
        public  Plane Plane { get; set; }

        public int PlaneFK { get; set; }


    }
}
