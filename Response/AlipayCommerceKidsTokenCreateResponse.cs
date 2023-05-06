using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceKidsTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceKidsTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [XmlElement("kids_token")]
        public string KidsToken { get; set; }
    }
}
