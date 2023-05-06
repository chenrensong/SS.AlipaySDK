using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// BaseOpenApiResponseHeaderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BaseOpenApiResponseHeaderDTO : AopObject
    {
        /// <summary>
        /// http状态码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }
    }
}
