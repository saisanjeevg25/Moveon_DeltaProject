using System;
using System.Collections.Generic;

#nullable disable

namespace MoveOn_Relocation_Company.Models
{
    public partial class TblRequest
    {
        public int RowId { get; set; }
        public string JobApplicationNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ItemCategory { get; set; }
        public string ItemDescription { get; set; }
        public string ShipmentType { get; set; }
        public string FromCountry { get; set; }
        public string FromState { get; set; }
        public string FromCity { get; set; }
        public string FromAddress { get; set; }
        public string ToCountry { get; set; }
        public string ToState { get; set; }
        public string ToCity { get; set; }
        public string ToAddress { get; set; }
        public DateTime PickupDate { get; set; }
    }
}
