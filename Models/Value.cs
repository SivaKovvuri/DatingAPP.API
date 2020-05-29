﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatingApp.API.Models
{
    public class Value
    { 
        //[JsonIgnore]// Hiding this property in the Response
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
