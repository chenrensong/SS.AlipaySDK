using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosStallModifyResponse.
    /// </summary>
    public class KoubeiCateringPosStallModifyResponse : AopResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
