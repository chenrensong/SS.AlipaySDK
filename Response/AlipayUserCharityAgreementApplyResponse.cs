using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserCharityAgreementApplyResponse.
    /// </summary>
    public class AlipayUserCharityAgreementApplyResponse : AopResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
