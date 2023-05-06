using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationIsvStatusSyncResponse.
    /// </summary>
    public class AlipayCommerceOperationIsvStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
