using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserfordeviceCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspUserfordeviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作流水号
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
