﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car : Vehicle
    {
        
        public int Id { get; set; }
        public string Wheels { get; set; }      
        public bool Headlights { get; set; }


    }
}
