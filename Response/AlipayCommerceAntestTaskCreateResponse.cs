using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAntestTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceAntestTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("batch_id")]
        public long BatchId { get; set; }
    }
}
