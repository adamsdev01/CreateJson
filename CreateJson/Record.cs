using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateJson
{
    public class Record
    {
        public int RecordId { get; set; } = 1;
        public string RecordName { get; set; } = "Astroworld";
        public string ArtistName { get; set; } = "Travis Scott";
        public DateTime? PurchaseDate { get; set; } = null;

    }
}
