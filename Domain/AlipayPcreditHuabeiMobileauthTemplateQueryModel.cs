using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMobileauthTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
