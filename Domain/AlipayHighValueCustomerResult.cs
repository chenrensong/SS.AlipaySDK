using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayHighValueCustomerResult : AopObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
