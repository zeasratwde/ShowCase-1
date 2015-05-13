using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsratShowCase.Models
{
    public class StateInfo
    {
        [Required, KeyAttribute]
        public int stateID { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string capital { get; set; }
        public string mostPopulousCity { get; set; }
        public int population { get; set; }
        public int squareMiles { get; set; }
        public string timeZone1 { get; set; }
        public string timeZone2 { get; set; }
        public string dst { get; set; }
        public byte[] stateFlag { get; set; }
        public byte[] stateSymbol { get; set; }
    }
}
