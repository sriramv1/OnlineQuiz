﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineQuiz
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineQuizEntities : DbContext
    {
        public OnlineQuizEntities()
            : base("name=OnlineQuizEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }
        public virtual DbSet<tbl_Quiz> tbl_Quiz { get; set; }
        public virtual DbSet<tbl_Questions> tbl_Questions { get; set; }
        public virtual DbSet<tbl_QuizQuestionRelation> tbl_QuizQuestionRelation { get; set; }
    }
}
