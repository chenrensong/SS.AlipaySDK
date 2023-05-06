using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenmockQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenmockQueryModel : AopObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("adfs")]
        public string Adfs { get; set; }

        /// <summary>
        /// xxxxx
        /// </summary>
        [XmlElement("xxsa")]
        public string Xxsa { get; set; }
    }
}
