﻿using ETicaratApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public partial class WorkTask
    {
        [Key]
        public int WorkTaskId { get; set; }


        public virtual Admin Admin { get; set; }

    }
}