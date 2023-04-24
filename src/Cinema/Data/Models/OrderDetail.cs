using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int MovieID { get; set; }

        public uint price { get; set; }
        //колво людей, время, часов
        public virtual Movie movie { get; set; }

        public virtual Order order { get; set; }
    }
}
