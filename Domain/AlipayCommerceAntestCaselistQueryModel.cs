using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceAntestCaselistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestCaselistQueryModel : AopObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }
    }
}
