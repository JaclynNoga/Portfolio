using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jaclyn_Noga_Portfolio.Models
{
    public class Projects
    {
        [Key]
        public int ProjectID { get; set; }

        [Display(Name = "Title")]
        public string ProjTitle { get; set; }

        [Display(Name = "Type of Project")]
        public string ProjType { get; set; }

        [Display(Name = "Image Source")]
        public string ProjImgSrc { get; set; }

        [Display(Name = "Language(s)")]
        public string ProjLang { get; set; }

        [Display(Name = "Description")]
        public string ProjDescr { get; set; }

        [Display(Name = "Complete?")]
        public bool ProjComplete { get; set; } = true;

        [Display(Name = "Completion Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMM yyyy}")]
        public System.Nullable<DateTime> ProjCompleteDate { get; set; }

        [Display(Name = "Code Source")]
        public string GitSrc { get; set; }

        [Display(Name = "Partner?")]
        public bool Partner { get; set; } = false;
        [Display(Name = "Partner Full Name")]
        public string ProjParnterFullName { get; set; } = null;
    }
}