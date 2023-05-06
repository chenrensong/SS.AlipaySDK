using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentAnalyzeSyncResponse.
    /// </summary>
    public class AlipaySecurityRiskContentAnalyzeSyncResponse : AopResponse
    {
        /// <summary>
        /// 唯一请求ID
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        [XmlElement("response")]
        public InfoSecAnalyzeSyncResult Response { get; set; }
    }
}
