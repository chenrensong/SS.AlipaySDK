using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundworkCreateResponse : AopResponse
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [XmlElement("inbound_work_id")]
        public string InboundWorkId { get; set; }
    }
}
