using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserApplepayOtpresolutionmethodsQueryResponse.
    /// </summary>
    public class AlipayUserApplepayOtpresolutionmethodsQueryResponse : AopResponse
    {
        /// <summary>
        /// OpenApi的Otp校验方法负责对象
        /// </summary>
        [XmlElement("resolution_methods")]
        public OpenApiResolutionMethod ResolutionMethods { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
