using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁通行证id
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }
    }
}
