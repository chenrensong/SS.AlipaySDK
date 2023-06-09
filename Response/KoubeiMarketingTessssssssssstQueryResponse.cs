using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingTessssssssssstQueryResponse.
    /// </summary>
    public class KoubeiMarketingTessssssssssstQueryResponse : AopResponse
    {
        /// <summary>
        /// a
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("category")]
        public Category Category { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("output")]
        public SpiOutputObject Output { get; set; }
    }
}
