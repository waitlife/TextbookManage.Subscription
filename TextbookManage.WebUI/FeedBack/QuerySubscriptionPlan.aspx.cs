﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Web.UI;
using TextbookManage.WebUI.FeedbackService;
using TextbookManage.WebUI.TermService;


namespace TextbookManage.WebUI.FeedBack
{
    public partial class QuerySubscriptionPlan : USCTAMis.Web.WebControls.Page
    {

        #region 属性

        //获取用户信息
        //ProfileManger profile = new ProfileManger(HttpContext.Current.User.Identity.Name);
        //获取登录名
        readonly string _loginName = HttpContext.Current.User.Identity.Name;
        //readonly string _loginName = "dongxb";
        //新华书店，dongxb
        //外国语学院院长，42018
        //教材科,hynhpgj
        //教务处，jwclsl

        #endregion

        #region 页面加载

        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //学期
                ccmbTerm.DoDataBind();
                //获取书商列表
                ccmbBookseller.DataBind();
                //获取回告状态                               
                ccmbFeedbackState.DataBind();
            }
        }

        #endregion

        #region 学期

        protected void ccmbTerm_DataBinding(object sender, EventArgs e)
        {
            using (TermApplClient app = new TermApplClient())
            {
                var result = app.GetAllTerms();
                ccmbTerm.DataSource = result;
            }
        }


        protected void ccmbTerm_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            cgrdOrderSet.DoDataBind();
        }
        #endregion

        #region 书商

        /// <summary>
        /// 书商
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ccmbBookseller_BeforeDataBind(object sender, EventArgs e)
        {
            using (FeedbackApplClient app = new FeedbackApplClient())
            {
                ccmbBookseller.DataSource = app.GetBookseller(_loginName);
            }
        }

        #endregion

        #region 回告状态

        /// <summary>
        /// 回告状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ccmbFeedbackState_BeforeDataBind(object sender, EventArgs e)
        {
            using (FeedbackApplClient app = new FeedbackApplClient())
            {
                ccmbFeedbackState.DataSource = app.GetFeedbackState();
            }
        }


        protected void ccmbFeedbackState_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            cgrdOrderSet.DoDataBind();
        }
        #endregion

        #region 查询

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cbtnQuery_Click(object sender, EventArgs e)
        {
            cgrdOrderSet.DoDataBind();
        }
        #endregion

        #region 订单

        /// <summary>
        /// 取订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cgrdOrderSet_BeforeDataBind(object sender, EventArgs e)
        {
            //学期
            string term = ccmbTerm.SelectedValue;
            //书商ID
            string booksellerId = ccmbBookseller.SelectedValue;
            //回告状态ID
            string feedbackState = ccmbFeedbackState.SelectedValue;

            using (FeedbackApplClient app = new FeedbackApplClient())
            {
                cgrdOrderSet.DataSource = app.GetSubscriptionByBooksellerId(term, booksellerId, feedbackState);
            }
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cgrdOrderSet_BeforePageIndexChanged(object sender, EventArgs e)
        {
            cgrdOrderSet.PersistCheckState<SubscriptionForFeedbackView>();
        }
        #endregion



    }
}