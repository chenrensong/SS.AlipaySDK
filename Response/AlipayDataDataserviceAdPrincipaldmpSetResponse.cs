using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSetResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipaldmpSetResponse : AopResponse
    {
        /// <summary>
        /// 操作结果：true-成功；false-失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
