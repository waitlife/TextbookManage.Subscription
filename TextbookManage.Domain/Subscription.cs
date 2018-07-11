using System;
using System.Collections.Generic;
using TextbookManage.Domain.Models.JiaoWu;

namespace TextbookManage.Domain.Models
{
    public class Subscription 
    {
        public Subscription()
        {
            TeacherDeclarations = new List<TeacherDeclaration>();
            StudentDeclarations = new List<StudentDeclaration>();
        }

        #region ����

        /// <summary>
        /// ����ID
        /// </summary>
        //public Guid SubscriptionId { get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        public Guid? Bookseller_Id { get; set; }
        /// <summary>
        /// �̲�ID
        /// </summary>
        public Guid Textbook_Id { get; set; }
        /// <summary>
        /// �ظ�ID
        /// </summary>
        public Guid? Feedback_Id { get; set; }
        /// <summary>
        /// ѧ��ѧ��
        /// </summary>
        public SchoolYearTerm SchoolYearTerm { get; set; }
        /// <summary>
        /// �ƻ�����
        /// </summary>
        public int PlanCount { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public int SpareCount { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public System.DateTime SubscriptionDate { get; set; }
        /// <summary>
        /// �ظ�״̬
        /// </summary>
        public FeedbackState FeedbackState { get; set; }
        /// <summary>
        /// ������־
        /// </summary>
        public byte[] RowVersion { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public virtual Bookseller Bookseller { get; set; }

        /// <summary>
        /// �̲�
        /// </summary>
        public virtual Textbook Textbook { get; set; }
        /// <summary>
        /// ��ʦ�����걨
        /// </summary>
        public virtual ICollection<TeacherDeclaration> TeacherDeclarations { get; set; }
        /// <summary>
        /// ѧ�������걨
        /// </summary>
        public virtual ICollection<StudentDeclaration> StudentDeclarations { get; set; }
        #endregion



    }
}