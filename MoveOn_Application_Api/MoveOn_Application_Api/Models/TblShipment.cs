using System;
using System.Collections.Generic;

#nullable disable

namespace MoveOn_Application_Api.Models
{
    public partial class TblShipment
    {
        public TblShipment()
        {
            TblRequests = new HashSet<TblRequest>();
        }

        public int ShipmentTypeId { get; set; }
        public string ShipmentType { get; set; }

        public virtual ICollection<TblRequest> TblRequests { get; set; }
    }
}
