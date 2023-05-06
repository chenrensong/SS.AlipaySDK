using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// TechriskTechriskTtYOnlineResponse.
    /// </summary>
    public class TechriskTechriskTtYOnlineResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public ManjiangTestabc S { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_open_id")]
        public string TestOpenId { get; set; }
    }
}
