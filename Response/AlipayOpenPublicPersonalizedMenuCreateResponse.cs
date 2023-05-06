using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuCreateResponse : AopResponse
    {
        /// <summary>
        /// 该套个性化菜单key
        /// </summary>
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }
    }
}
