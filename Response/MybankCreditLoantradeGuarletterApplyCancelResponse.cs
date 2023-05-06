using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyCancelResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterApplyCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
