﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    internal abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
