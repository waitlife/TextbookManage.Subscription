﻿using TextbookManage.Infrastructure;

namespace TextbookManage.Domain.Models.JiaoWu
{
    /// <summary>
    /// 用于与教务的教师用书申报映射
    /// </summary>
    public class TeacherDeclarationJiaoWu : DeclarationJiaoWu
    {
        ///// <summary>
        ///// 申报数量
        ///// </summary>
        //[NotMapped]
        //public override int DeclarationCount { get; set; }
        /// <summary>
        /// 教材的学生用书申报
        /// </summary>
        //public virtual DeclarationTextbook DeclarationTextbook { get; set; }
        /// <summary>
        /// 教材的用书申报
        /// </summary>
        public virtual TeacherDeclaration DeclarationTextbook { get; set; }


        private string hdsl;
    }
}
