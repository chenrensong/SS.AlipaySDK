using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaMerchantZmgoTemplateCreateResponse.
    /// </summary>
    public class ZhimaMerchantZmgoTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 芝麻GO模板号
        /// </summary>
        [XmlElement("template_no")]
        public string TemplateNo { get; set; }
    }
}
