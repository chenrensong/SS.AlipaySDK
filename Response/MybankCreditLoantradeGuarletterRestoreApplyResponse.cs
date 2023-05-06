using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterRestoreApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterRestoreApplyResponse : AopResponse
    {
        /// <summary>
        /// 受理申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
