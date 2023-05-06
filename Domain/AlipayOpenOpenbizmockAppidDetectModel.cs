using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmockAppidDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmockAppidDetectModel : AopObject
    {
        /// <summary>
        /// APPID值
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }
    }
}
