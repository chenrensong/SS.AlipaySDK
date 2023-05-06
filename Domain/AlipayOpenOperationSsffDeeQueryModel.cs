using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenOperationSsffDeeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationSsffDeeQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("df")]
        public string Df { get; set; }
    }
}
