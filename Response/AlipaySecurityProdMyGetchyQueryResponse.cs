using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySecurityProdMyGetchyQueryResponse.
    /// </summary>
    public class AlipaySecurityProdMyGetchyQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("chen")]
        public string Chen { get; set; }
    }
}
