//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monitor()
        {
            this.MonitorTasks = new HashSet<MonitorTask>();
        }
    
        public int Monitor_ID { get; set; }
        public string Monitor_Name { get; set; }
        public string Monitor_Type { get; set; }
        public int Station_ID { get; set; }
    
        public virtual Station Station { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonitorTask> MonitorTasks { get; set; }
    }
}