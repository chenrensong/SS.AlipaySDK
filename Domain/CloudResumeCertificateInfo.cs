using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// CloudResumeCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumeCertificateInfo : AopObject
    {
        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("certificate_name")]
        public string CertificateName { get; set; }
    }
}
