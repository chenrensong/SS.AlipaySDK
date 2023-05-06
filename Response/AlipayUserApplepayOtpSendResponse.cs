using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserApplepayOtpSendResponse.
    /// </summary>
    public class AlipayUserApplepayOtpSendResponse : AopResponse
    {
        /// <summary>
        /// 响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
