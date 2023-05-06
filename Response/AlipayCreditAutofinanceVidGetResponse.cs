using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetResponse.
    /// </summary>
    public class AlipayCreditAutofinanceVidGetResponse : AopResponse
    {
        /// <summary>
        /// 核身VID
        /// </summary>
        [XmlElement("verifyid")]
        public string Verifyid { get; set; }
    }
}
