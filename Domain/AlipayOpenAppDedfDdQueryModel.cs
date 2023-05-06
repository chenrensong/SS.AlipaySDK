using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppDedfDdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDedfDdQueryModel : AopObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("zyde")]
        public string Zyde { get; set; }
    }
}
