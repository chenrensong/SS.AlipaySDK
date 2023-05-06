using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleCreateResponse : AopResponse
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
