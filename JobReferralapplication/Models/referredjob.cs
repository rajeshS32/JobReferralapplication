//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobReferralapplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class referredjob
    {
        [Key]
        
        public int jobrefernceid { get; set; }
        [Required]
        public string referredto { get; set; }
        public int jobid { get; set; }
        public System.DateTime referredon { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
    }
}