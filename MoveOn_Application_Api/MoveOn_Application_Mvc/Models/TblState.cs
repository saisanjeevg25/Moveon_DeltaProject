﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MoveOn_Application_Mvc.Models
{
    public partial class TblState
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
    }
}
