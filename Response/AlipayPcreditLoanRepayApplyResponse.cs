using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditLoanRepayApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanRepayApplyResponse : AopResponse
    {
        /// <summary>
        /// 跳转至支付宝地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 还款申请受理单号
        /// </summary>
        [XmlElement("repay_receipt_no")]
        public string RepayReceiptNo { get; set; }
    }
}
