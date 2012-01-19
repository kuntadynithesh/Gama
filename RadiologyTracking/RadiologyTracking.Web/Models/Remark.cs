﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadiologyTracking.Web.Utility;
using System.ComponentModel.DataAnnotations;

namespace RadiologyTracking.Web.Models
{
    public class Remark
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public String Value { get; set; }

        public static Remark getRemark(string remark, RadiologyContext ctx)
        {
            return ctx.Remarks.FirstOrDefault(p => p.Value.ToUpper() == remark.ToUpper());
        }
    }
}
