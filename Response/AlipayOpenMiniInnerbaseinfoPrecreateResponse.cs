using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoPrecreateResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
