using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMsaasItapStatesSyncResponse.
    /// </summary>
    public class AlipayMsaasItapStatesSyncResponse : AopResponse
    {
        /// <summary>
        /// Itap统一放回结果模型
        /// </summary>
        [XmlArray("payload")]
        [XmlArrayItem("itap_response_payload")]
        public List<ItapResponsePayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
