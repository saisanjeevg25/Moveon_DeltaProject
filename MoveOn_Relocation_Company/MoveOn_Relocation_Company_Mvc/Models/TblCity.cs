﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MoveOn_Relocation_Company_Mvc.Models
{
    public partial class TblCity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
