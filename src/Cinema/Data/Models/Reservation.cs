using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Models
{
    public class Reservation
    {
        [Key]
        public int id { get; set; }
        
        public int data { get; set; }

        public DateTime month { get; set; }

        public DateTime day { get; set; }

        public DateTime hour { get; set; }

        public DateTime minute { get; set; }

        public int rentedHours { get; set; }

        public int people { get; set; }

        public string ReservationId { get; set; }
    }
}
