using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdMyGetchyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdMyGetchyQueryModel : AopObject
    {
        /// <summary>
        /// chen
        /// </summary>
        [XmlElement("chen")]
        public string Chen { get; set; }
    }
}
