using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppTestQinyuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestQinyuQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }
    }
}
