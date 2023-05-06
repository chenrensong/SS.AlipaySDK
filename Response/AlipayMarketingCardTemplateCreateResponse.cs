using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝卡模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
