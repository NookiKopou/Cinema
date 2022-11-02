using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Models
{
    public class Movie
    {
        public int id { set; get; }

        public string name { set; get; }

        public string desc { set; get; }

        public double grade { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public double duration { set; get; }

        public string place { set; get; }

        public string carrier { set; get; }

        public bool isPopular { set; get; }

        public int genreID { set; get; }

        public virtual Genre Genre { set; get; }
    }
}
