using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicExplanationSyncResponse.
    /// </summary>
    public class AlipayCommerceDataScenicExplanationSyncResponse : AopResponse
    {
        /// <summary>
        /// 成功请求ID。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
