using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecSyncResponse.
    /// </summary>
    public class KoubeiCateringPosSpecSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
