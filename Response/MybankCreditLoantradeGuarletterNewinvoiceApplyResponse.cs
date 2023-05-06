using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterNewinvoiceApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterNewinvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
