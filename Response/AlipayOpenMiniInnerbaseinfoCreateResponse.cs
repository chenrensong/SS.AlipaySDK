using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
