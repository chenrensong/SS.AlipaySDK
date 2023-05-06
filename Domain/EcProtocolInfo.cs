using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// EcProtocolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcProtocolInfo : AopObject
    {
        /// <summary>
        /// 法务协议id编号
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 法务协议名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 法务协议链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
