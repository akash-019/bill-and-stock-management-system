//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BSMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Biller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Biller()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int Id { get; set; }
        public int Branch_ID { get; set; }
        public string Contact { get; set; }
        public System.DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
