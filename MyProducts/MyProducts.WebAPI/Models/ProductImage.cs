//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProducts.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImage
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public int ProductId { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.DateTime UpdatedDateTime { get; set; }
    }
}
