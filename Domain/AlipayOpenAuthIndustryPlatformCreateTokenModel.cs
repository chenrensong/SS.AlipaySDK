using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformCreateTokenModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AopObject
    {
        /// <summary>
        /// isv的appid
        /// </summary>
        [XmlElement("isv_appid")]
        public string IsvAppid { get; set; }

        /// <summary>
        /// auth_mycar_violation
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }
    }
}
