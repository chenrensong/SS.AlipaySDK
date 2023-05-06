using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMytestoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMytestoQueryModel : AopObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("auth")]
        public ZmAuthParams Auth { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("extend_params")]
        public ExtendParams ExtendParams { get; set; }
    }
}
