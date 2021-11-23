using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoveOn_Relocation_Company_Mvc.Models
{
    public partial class Request
    {
        [Key]
        public int RowId { get; set; }
        public string JobApplicationNumber { get; set; }
        [Required(ErrorMessage = "Please Provide Your Name")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Name Should be Minimum of 3 Characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Provide Your Mobile Number")]
        [StringLength(10, MinimumLength =10, ErrorMessage = "Number Should be of 10 digits")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = " Please Enter Numbers")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Provide Your Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please Provide a Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide item Category")]
        public string ItemCategory { get; set; }
        public string ItemDescription { get; set; }
        [Required(ErrorMessage = "Please Provide Shipment Type")]
        public string ShipmentType { get; set; }
        [Required(ErrorMessage = "Please Provide From Country")]
        public string FromCountry { get; set; }
        [Required(ErrorMessage = "Please Provide From State")]
        public string FromState { get; set; }
        [Required(ErrorMessage = "Please Provide From City")]
        public string FromCity { get; set; }
        [Required(ErrorMessage = "Please Provide From Address")]
        [StringLength(60, MinimumLength = 20, ErrorMessage = "Address Should be Minimum of 20 Characters")]
        public string FromAddress { get; set; }
        [Required(ErrorMessage = "Please Provide To Country")]
        public string ToCountry { get; set; }
        [Required(ErrorMessage = "Please Provide To State")]
        public string ToState { get; set; }
        [Required(ErrorMessage = "Please Provide To City")]
        public string ToCity { get; set; }
        [Required(ErrorMessage = "Please Provide To Address")]
        [StringLength(60, MinimumLength = 20, ErrorMessage = "Address Should be Minimum of 20 Characters")]
        public string ToAddress { get; set; }
        [Required(ErrorMessage = "Please Provide Pick Up Date")]
        [DataType(DataType.Date)]
        public DateTime PickupDate { get; set; }
    }
}
