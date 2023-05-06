using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySamsungPucChargeResponse.
    /// </summary>
    public class AlipaySamsungPucChargeResponse : AopResponse
    {
        /// <summary>
        /// zhijiefanhui yemian
        /// </summary>
        [XmlElement("page_retrun")]
        public string PageRetrun { get; set; }
    }
}
