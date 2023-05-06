using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundworkCreateResponse : AopResponse
    {
        /// <summary>
        /// 出库作业id
        /// </summary>
        [XmlElement("outbound_work_id")]
        public string OutboundWorkId { get; set; }
    }
}
