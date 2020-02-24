using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace International_Web_Form.Models
{
    public class Country
    {
        public string country { get; set; }
        public string RegionType { get; set; }
        public string localeType { get; set; }
        public int CodeLenght { get; set; }
        public string CodeType { get; set; }
    }
}