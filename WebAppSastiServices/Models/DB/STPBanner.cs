//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppSastiServices.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class STPBanner
    {
        public int ID { get; set; }
        public string BannerName { get; set; }
        public string BannerDetails { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageFilePath1 { get; set; }
        public string ImageFilePath2 { get; set; }
        public string ImageFilePath3 { get; set; }
        public string ImageFilePath4 { get; set; }
        public System.DateTime createdDateTime { get; set; }
    }
}
