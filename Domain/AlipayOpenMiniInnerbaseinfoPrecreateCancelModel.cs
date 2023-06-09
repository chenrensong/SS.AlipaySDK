using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoPrecreateCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoPrecreateCancelModel : AopObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
