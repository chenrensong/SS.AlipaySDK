using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestabcAbcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdXwbtestabcAbcQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwb")]
        public string Xwb { get; set; }
    }
}
