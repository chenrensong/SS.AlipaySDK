using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MybankCreditSceneprodPrepaymentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodPrepaymentApplyModel : AopObject
    {
        /// <summary>
        /// 网商申请单号(必须S结尾)
        /// </summary>
        [XmlElement("app_seq_no")]
        public string AppSeqNo { get; set; }

        /// <summary>
        /// 枚举值  a.退车 loanCancel  b.机构主动回购 activeRefund  c.客户主动结清 repayByCust
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 借款人姓名
        /// </summary>
        [XmlElement("cust_name")]
        public string CustName { get; set; }

        /// <summary>
        /// 网商支用号（必须V结尾）
        /// </summary>
        [XmlElement("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 借款人身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// operate_mode操作类型代表当前接口的调用形态，是一个枚举值，目前分为以下三个值：  a.提前还款试算查询 prepaymentBudgetQuery  b.提前还款申请 prepaymentApply  c.提前还款结果查询 prepaymentResultQuery
        /// </summary>
        [XmlElement("operate_mode")]
        public string OperateMode { get; set; }

        /// <summary>
        /// 提前还款总金额（单位分）  提前还款申请时必填 prepayment_amt=print_amt + int_amt + pen_amt
        /// </summary>
        [XmlElement("prepayment_amt")]
        public string PrepaymentAmt { get; set; }

        /// <summary>
        /// 提前还款申请单号(提前还款查询时必须传)  提前还款申请单号是提前还款受理阶段的网商侧返回的提前还款申请单号。
        /// </summary>
        [XmlElement("prepayment_apply_no")]
        public string PrepaymentApplyNo { get; set; }

        /// <summary>
        /// 提前还款利息（单位分）  提前还款申请时必填
        /// </summary>
        [XmlElement("prepayment_int_amt")]
        public string PrepaymentIntAmt { get; set; }

        /// <summary>
        /// 提前还款罚金（单位分）  提前还款申请时必填
        /// </summary>
        [XmlElement("prepayment_pen_amt")]
        public string PrepaymentPenAmt { get; set; }

        /// <summary>
        /// 前还款本金（单位分）  提前还款申请时必填
        /// </summary>
        [XmlElement("prepayment_prin_amt")]
        public string PrepaymentPrinAmt { get; set; }

        /// <summary>
        /// 还款方式，目前固定为 Clear（全额还款结清）
        /// </summary>
        [XmlElement("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// request_id是一个请求幂等号，在网络抖动/超时情况下，使用相同的requestId可幂等获取原有值
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
