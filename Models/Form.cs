using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace International_Address_Form.Models
{

    public class Form
    {
        public long Id { get; set; }
        public string AddressLine0 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }
        public int Code { get; set; }
    }
}
