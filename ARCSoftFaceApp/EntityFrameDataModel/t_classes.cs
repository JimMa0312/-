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
    
    public partial class t_classes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_classes()
        {
            this.t_student = new HashSet<t_student>();
        }
    
        public int class_id { get; set; }
        public string college_name { get; set; }
        public string teacher_id { get; set; }
        public Nullable<int> class_people_num { get; set; }
    
        public virtual t_teacher t_teacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_student> t_student { get; set; }
    }
}
