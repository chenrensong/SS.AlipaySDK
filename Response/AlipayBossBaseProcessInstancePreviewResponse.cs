using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstancePreviewResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstancePreviewResponse : AopResponse
    {
        /// <summary>
        /// 预演返回结果
        /// </summary>
        [XmlElement("preview_step")]
        public BPOpenApiInstancePreviewStep PreviewStep { get; set; }
    }
}
