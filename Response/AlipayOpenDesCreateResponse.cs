using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenDesCreateResponse.
    /// </summary>
    public class AlipayOpenDesCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ces")]
        public GavintestNewLeveaOne Ces { get; set; }
    }
}
