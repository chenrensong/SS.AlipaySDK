using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenDeleteResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenDeleteResponse : AopResponse
    {
        /// <summary>
        /// 响应报文头部
        /// </summary>
        [XmlElement("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }
    }
}
