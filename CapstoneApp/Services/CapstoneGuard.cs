//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapstoneApp.Services
{
    using System;
    using System.Collections.Generic;
    
    public partial class CapstoneGuard
    {
        public int BadgeNumber { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> PatrolCar { get; set; }
    
        public virtual CapstoneEmployee CapstoneEmployee { get; set; }
        public virtual CapstonePatrolCar CapstonePatrolCar { get; set; }
    }
}
