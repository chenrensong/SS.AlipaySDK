using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZolozAuthenticationSmilefaceSendmeSendResponse.
    /// </summary>
    public class ZolozAuthenticationSmilefaceSendmeSendResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
