//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARCSoftFaceApp.EntityFrameDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_teacher()
        {
            this.t_classes = new HashSet<t_classes>();
            this.t_course = new HashSet<t_course>();
        }
    
        public string teacher_id { get; set; }
        public Nullable<int> dept_id { get; set; }
        public string teacher_name { get; set; }
        public string teacher_gender { get; set; }
        public string teacher_email { get; set; }
        public string teacher_qq { get; set; }
        public Nullable<long> user_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_classes> t_classes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_course> t_course { get; set; }
        public virtual t_dept t_dept { get; set; }
        public virtual t_user t_user { get; set; }
    }
}