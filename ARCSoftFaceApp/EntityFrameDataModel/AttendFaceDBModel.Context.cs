﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class attendance_sysEntities : DbContext
    {
        public attendance_sysEntities()
            : base("name=attendance_sysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_attend> t_attend { get; set; }
        public virtual DbSet<t_attenditem> t_attenditem { get; set; }
        public virtual DbSet<t_attendrule> t_attendrule { get; set; }
        public virtual DbSet<t_camera> t_camera { get; set; }
        public virtual DbSet<t_classes> t_classes { get; set; }
        public virtual DbSet<t_classroom> t_classroom { get; set; }
        public virtual DbSet<t_college> t_college { get; set; }
        public virtual DbSet<t_course> t_course { get; set; }
        public virtual DbSet<t_dept> t_dept { get; set; }
        public virtual DbSet<t_faceinfo> t_faceinfo { get; set; }
        public virtual DbSet<t_student> t_student { get; set; }
        public virtual DbSet<t_teacher> t_teacher { get; set; }
        public virtual DbSet<t_user> t_user { get; set; }
    }
}
