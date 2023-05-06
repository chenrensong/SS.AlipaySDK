using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdProtocolOrderPreviewResponse.
    /// </summary>
    public class AlipayBossProdProtocolOrderPreviewResponse : AopResponse
    {
        /// <summary>
        /// 协议预览结果
        /// </summary>
        [XmlElement("protocol_preview_vo_list")]
        public ProtocolPreviewVO ProtocolPreviewVoList { get; set; }
    }
}
