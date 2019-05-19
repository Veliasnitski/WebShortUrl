using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Url
    {
        public Url()
        {

        }
        public Url(string idshort, string full, DateTime? date, int? count)
        {
            IdShortUrl = idshort;
            FullUrl = full;
            DateCreate = date;
            Count = count;
        }
        public string IdShortUrl { get; set; }
        public string FullUrl { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? Count { get; set; }
    }
}
