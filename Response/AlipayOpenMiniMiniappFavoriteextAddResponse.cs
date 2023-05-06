using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteextAddResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoriteextAddResponse : AopResponse
    {
        /// <summary>
        /// 成功：true  失败：false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
