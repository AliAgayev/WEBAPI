﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Hospital : BaseEntity
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
