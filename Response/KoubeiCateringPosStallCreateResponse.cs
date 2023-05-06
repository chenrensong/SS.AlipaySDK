using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosStallCreateResponse.
    /// </summary>
    public class KoubeiCateringPosStallCreateResponse : AopResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
