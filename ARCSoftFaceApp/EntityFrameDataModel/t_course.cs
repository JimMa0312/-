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
    
    public partial class t_course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_course()
        {
            this.t_attend = new HashSet<t_attend>();
        }
    
        public long course_id { get; set; }
        public Nullable<int> class_id { get; set; }
        public string classroom_id { get; set; }
        public string course_name { get; set; }
        public string teacher_id { get; set; }
        public Nullable<System.DateTime> course_date { get; set; }
        public string course_start_week { get; set; }
        public string course_end_week { get; set; }
        public string school_year { get; set; }
        public string semester { get; set; }
        public string grade { get; set; }
        public string course_start_time { get; set; }
        public string course_end_time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_attend> t_attend { get; set; }
        public virtual t_teacher t_teacher { get; set; }
    }
}
