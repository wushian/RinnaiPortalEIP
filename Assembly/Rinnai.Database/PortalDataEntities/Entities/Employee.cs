//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalDataEntities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentID_FK { get; set; }
        public string CostDepartmentID { get; set; }
        public string AgentID { get; set; }
        public bool Disabled { get; set; }
        public Nullable<System.DateTime> DisabledDate { get; set; }
        public string ADAccount { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string AccessType { get; set; }
        public string NationalType { get; set; }
        public string SexType { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
