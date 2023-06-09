using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除成功，返回主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
