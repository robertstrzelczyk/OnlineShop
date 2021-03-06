//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specs()
        {
            this.Products = new HashSet<Products>();
        }
    
        public int ID { get; set; }
        public string Processor { get; set; }
        public Nullable<int> RAM { get; set; }
        public Nullable<int> Max_RAM { get; set; }
        public Nullable<int> Disk_size { get; set; }
        public string Disk_type { get; set; }
        public string Display_type { get; set; }
        public Nullable<decimal> Display_size { get; set; }
        public string Resolution { get; set; }
        public string Graphics_card { get; set; }
        public string Battery { get; set; }
        public string OS { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Depth { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<int> Warranty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
