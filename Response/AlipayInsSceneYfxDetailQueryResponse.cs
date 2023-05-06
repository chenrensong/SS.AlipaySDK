using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneYfxDetailQueryResponse.
    /// </summary>
    public class AlipayInsSceneYfxDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 运费险详情
        /// </summary>
        [XmlElement("yfx_info")]
        public InsOpenYfxInfoDTO YfxInfo { get; set; }
    }
}
