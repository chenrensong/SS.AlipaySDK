using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmServicerecordCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmServicerecordCreateResponse : AopResponse
    {
        /// <summary>
        /// 服务记录ID
        /// </summary>
        [XmlElement("service_record_id")]
        public string ServiceRecordId { get; set; }
    }
}
