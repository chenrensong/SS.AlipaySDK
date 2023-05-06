using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPagetemplateGetResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPagetemplateGetResponse : AopResponse
    {
        /// <summary>
        /// 模版code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模版详情
        /// </summary>
        [XmlElement("template_info")]
        public PageTemplateInfoDTO TemplateInfo { get; set; }
    }
}
