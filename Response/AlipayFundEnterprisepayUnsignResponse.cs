using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundEnterprisepayUnsignResponse.
    /// </summary>
    public class AlipayFundEnterprisepayUnsignResponse : AopResponse
    {
        /// <summary>
        /// 解约凭证
        /// </summary>
        [XmlElement("unsign_token")]
        public string UnsignToken { get; set; }

        /// <summary>
        /// 解约链接
        /// </summary>
        [XmlElement("unsign_url")]
        public string UnsignUrl { get; set; }
    }
}
