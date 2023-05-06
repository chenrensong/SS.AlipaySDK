using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdMyTestQueryResponse.
    /// </summary>
    public class AlipayBossProdMyTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
