using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyResponse.
    /// </summary>
    public class KoubeiMarketingMallMemberModifyResponse : AopResponse
    {
        /// <summary>
        /// true：成功，false：失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
