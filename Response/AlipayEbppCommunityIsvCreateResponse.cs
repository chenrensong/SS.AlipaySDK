using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppCommunityIsvCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityIsvCreateResponse : AopResponse
    {
        /// <summary>
        /// ISV短名
        /// </summary>
        [XmlElement("isv_short_name")]
        public string IsvShortName { get; set; }
    }
}
