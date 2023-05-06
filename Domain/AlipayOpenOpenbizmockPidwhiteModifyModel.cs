using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmockPidwhiteModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmockPidwhiteModifyModel : AopObject
    {
        /// <summary>
        /// APPID
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }
    }
}
