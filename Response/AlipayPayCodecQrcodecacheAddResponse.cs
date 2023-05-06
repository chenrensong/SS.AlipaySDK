using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPayCodecQrcodecacheAddResponse.
    /// </summary>
    public class AlipayPayCodecQrcodecacheAddResponse : AopResponse
    {
        /// <summary>
        /// true或者false
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
