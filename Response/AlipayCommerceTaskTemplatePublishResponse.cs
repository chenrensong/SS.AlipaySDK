using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTaskTemplatePublishResponse.
    /// </summary>
    public class AlipayCommerceTaskTemplatePublishResponse : AopResponse
    {
        /// <summary>
        /// 任务模版
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
