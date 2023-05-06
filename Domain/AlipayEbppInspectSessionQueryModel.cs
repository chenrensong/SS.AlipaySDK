using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEbppInspectSessionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInspectSessionQueryModel : AopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("log_name")]
        public string LogName { get; set; }
    }
}
