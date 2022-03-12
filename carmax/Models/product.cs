//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace carmax.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.order_cars = new HashSet<order_cars>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string max_power { get; set; }
        public string seating_capacity { get; set; }
        public string body_type { get; set; }
        public string fuel_type { get; set; }
        public string no_of_cylinder { get; set; }
        public string color { get; set; }
        public string engine_type { get; set; }
        public string engine_displacement { get; set; }
        public string type { get; set; }
        public string img { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public Nullable<int> discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_cars> order_cars { get; set; }
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}