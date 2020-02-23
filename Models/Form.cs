using System;

namespace International_Address_Form.Models
{

    public class Form
    {
        public int Id { get; set; }
        public string AddressLine0 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }
        public int Code { get; set; }
    }

    public class Country
    {
        public string country { get; set; }
        public string RegionType { get; set; }
        public string localeType { get; set; }
        public int CodeLenght { get; set; }
        public string CodeType { get; set; }
    }
}
