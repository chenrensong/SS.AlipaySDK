using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditLoanBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanBudgetQueryModel : AopObject
    {
        /// <summary>
        /// 风险日利率
        /// </summary>
        [XmlElement("daily_risk_int_rate")]
        public string DailyRiskIntRate { get; set; }

        /// <summary>
        /// 贷款金额
        /// </summary>
        [XmlElement("loan_amt")]
        public string LoanAmt { get; set; }

        /// <summary>
        /// 贷款期限
        /// </summary>
        [XmlElement("loan_term")]
        public LoanTerm LoanTerm { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 还款日
        /// </summary>
        [XmlElement("repay_day")]
        public long RepayDay { get; set; }

        /// <summary>
        /// 还款方式，取值{1, 3, 6}：1-等额本息; 3-按期付息到期还本;  6-到期一次性还本付息;
        /// </summary>
        [XmlElement("repay_mode")]
        public string RepayMode { get; set; }
    }
}
