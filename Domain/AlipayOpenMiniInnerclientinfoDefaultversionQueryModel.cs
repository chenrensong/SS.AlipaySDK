using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoDefaultversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerclientinfoDefaultversionQueryModel : AopObject
    {
        /// <summary>
        /// 小程序Id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
