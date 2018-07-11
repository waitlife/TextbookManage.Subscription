﻿using TextbookManage.Infrastructure;

namespace TextbookManage.Domain.Models.JiaoWu
{
    /// <summary>
    /// 用于与教务的学生用书申报映射
    /// </summary>
    public class StudentDeclarationJiaoWu : DeclarationJiaoWu
    {
        ///// <summary>
        ///// 申报数量
        ///// 教务系统的征订数量
        ///// </summary>
        //public override int DeclarationCount { get; set; }
        /// <summary>
        /// 教材的学生用书申报
        /// </summary>
        //public virtual DeclarationTextbook DeclarationTextbook { get; set; }
        /// <summary>
        /// 教材的用书申报
        /// </summary>
        public virtual StudentDeclaration DeclarationTextbook { get; set; }


        private int zdsl;
    }
}
