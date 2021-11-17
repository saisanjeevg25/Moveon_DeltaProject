using System;
using System.Collections.Generic;

#nullable disable

namespace MoveOn_Application_Mvc.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            TblRequests = new HashSet<Request>();
        }

        public int ShipmentTypeId { get; set; }
        public string ShipmentType { get; set; }

        public virtual ICollection<Request> TblRequests { get; set; }
    }
}
