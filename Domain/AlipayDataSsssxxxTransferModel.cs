using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDataSsssxxxTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataSsssxxxTransferModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ddd")]
        public string Ddd { get; set; }
    }
}
