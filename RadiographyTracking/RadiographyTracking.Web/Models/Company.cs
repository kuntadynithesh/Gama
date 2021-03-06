﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using RadiographyTracking.Web.Resources;
using System.ComponentModel;

namespace RadiographyTracking.Web.Models
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField=false)]
        public int ID { get; set; }

        [Display(Order=1, Description="This is the name that will be used in Final Printable Reports")]
        [Required(ErrorMessage ="Name of the company cannot be empty")]
        public String Name { get; set; }

        [Display(Order=2, Description="Short Name is used everywhere except final reports")]
        [Required(ErrorMessage = "Short Name of the company cannot be empty")]
        public String ShortName { get; set; }

        [Display(Order=3)]
        [Required(ErrorMessage="Address for the Company cannot be empty")]
        public String Address { get; set; }

        [Display(Order=4)]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessageResourceName = "ValidationErrorInvalidEmail", ErrorMessageResourceType = typeof(ValidationErrorResources))]
        public String Email { get; set; }

        [Display(Order=5)]
        public String WebSite { get; set; }

        [Display(Order=6)]
        public String PhoneNo { get; set; }

        [Display(AutoGenerateField=false)]
        public int? LogoID { get; set; }

        [Display(AutoGenerateField = false)]
        public UploadedFile Logo { get; set; }
    }
}