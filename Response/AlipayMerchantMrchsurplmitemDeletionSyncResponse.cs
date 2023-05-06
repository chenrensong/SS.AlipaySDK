using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemDeletionSyncResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmitemDeletionSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
