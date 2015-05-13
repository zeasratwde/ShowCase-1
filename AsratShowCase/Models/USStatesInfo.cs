using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AsratShowCase.Models
{
    public class USStatesInfo
    {
        [Required, KeyAttribute]
        public int stateID { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string capital { get; set; }
        public string mostPopulousCity { get; set; }
        public string population { get; set; }
        public string squareMiles { get; set; }
        public string timeZone1 { get; set; }
        public string timeZone2 { get; set; }
        public string dst { get; set; }
        public byte[] stateFlag { get; set; }
        public byte[] stateSymbol { get; set; }
    }
 
}