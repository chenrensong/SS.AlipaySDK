using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleModifyResponse.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleModifyResponse : AopResponse
    {
        /// <summary>
        /// ApplePay公用响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
