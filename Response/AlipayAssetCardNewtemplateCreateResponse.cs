using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayAssetCardNewtemplateCreateResponse.
    /// </summary>
    public class AlipayAssetCardNewtemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
