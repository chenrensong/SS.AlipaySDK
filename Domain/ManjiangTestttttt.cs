using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ManjiangTestttttt Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestttttt : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oi")]
        public string Oi { get; set; }
    }
}
