using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeInvalidDeleteResponse.
    /// </summary>
    public class MybankCreditLoanapplyQrcodeInvalidDeleteResponse : AopResponse
    {
        /// <summary>
        /// true:失效成功 false:失效失败
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
