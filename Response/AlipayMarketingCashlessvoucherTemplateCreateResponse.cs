using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCashlessvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
