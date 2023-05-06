using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryResponse : AopResponse
    {
        /// <summary>
        /// yufaa
        /// </summary>
        [XmlElement("yufaa")]
        public string Yufaa { get; set; }
    }
}
