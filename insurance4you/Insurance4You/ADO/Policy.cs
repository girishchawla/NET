//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance4You.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Policy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policy()
        {
            this.Drivers = new HashSet<Driver>();
        }
    
        public int Id { get; set; }
        public int CarID { get; set; }
        public int DriverID { get; set; }
        public Nullable<int> AdditionalDriverID { get; set; }
        public string PaymentID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public decimal Quote { get; set; }
        public bool Checked { get; set; }
        public Nullable<bool> Rejected { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
