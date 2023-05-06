using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerExperienceCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInnerExperienceCreateResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
