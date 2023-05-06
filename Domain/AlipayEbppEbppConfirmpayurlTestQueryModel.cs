using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEbppEbppConfirmpayurlTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppConfirmpayurlTestQueryModel : AopObject
    {
        /// <summary>
        /// ss
        /// </summary>
        [XmlElement("tess")]
        public string Tess { get; set; }
    }
}
