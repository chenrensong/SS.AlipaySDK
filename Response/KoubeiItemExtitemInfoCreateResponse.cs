using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoCreateResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功，返回id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
