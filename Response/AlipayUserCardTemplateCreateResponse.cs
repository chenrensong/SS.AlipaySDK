using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserCardTemplateCreateResponse.
    /// </summary>
    public class AlipayUserCardTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// template_id：卡模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
