﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CB.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }


        public ICollection<Appointment> Appointments;
    }
}
