//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marathon2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timesheet
    {
        public int TimesheetId { get; set; }
        public int StaffId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDatetime { get; set; }
        public Nullable<decimal> PayAmount { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}
