using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdiePreviewQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdiePreviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 站点页面预览数据返回值
        /// </summary>
        [XmlElement("data")]
        public FengdiePreviewQueryRespModel Data { get; set; }
    }
}
