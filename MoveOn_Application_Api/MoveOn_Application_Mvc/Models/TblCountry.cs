using System;
using System.Collections.Generic;

#nullable disable

namespace MoveOn_Application_Mvc.Models
{
    public partial class TblCountry
    {
        public int Id { get; set; }
        public string Shortname { get; set; }
        public string CountryName { get; set; }
        public int PhoneCode { get; set; }
    }
}
