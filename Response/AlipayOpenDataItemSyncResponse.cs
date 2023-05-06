using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenDataItemSyncResponse.
    /// </summary>
    public class AlipayOpenDataItemSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回更新成功的外部id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
