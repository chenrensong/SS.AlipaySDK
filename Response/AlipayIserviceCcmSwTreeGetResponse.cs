using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeGetResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeGetResponse : AopResponse
    {
        /// <summary>
        /// 类目树字符串
        /// </summary>
        [XmlElement("tree")]
        public string Tree { get; set; }
    }
}
