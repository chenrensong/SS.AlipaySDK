using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesDeleteResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesDeleteResponse : AopResponse
    {
        /// <summary>
        /// 返回删除云凤蝶站点成功与失败的结果
        /// </summary>
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
