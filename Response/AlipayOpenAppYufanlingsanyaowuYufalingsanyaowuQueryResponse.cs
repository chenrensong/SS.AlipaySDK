using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AopResponse
    {
        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
