using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeCreateResponse : AopResponse
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
