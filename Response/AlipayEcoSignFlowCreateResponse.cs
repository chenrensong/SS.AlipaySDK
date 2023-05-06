using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoSignFlowCreateResponse.
    /// </summary>
    public class AlipayEcoSignFlowCreateResponse : AopResponse
    {
        /// <summary>
        /// 流程Id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
