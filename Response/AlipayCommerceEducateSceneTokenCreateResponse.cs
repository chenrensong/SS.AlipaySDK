using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 请求生成场景token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
