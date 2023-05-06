using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSyncResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipaldmpSyncResponse : AopResponse
    {
        /// <summary>
        /// 关联结果：true-成功；false-失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
