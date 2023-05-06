using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateCertificateInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCertificateInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 证书列表
        /// </summary>
        [XmlArray("certificates")]
        [XmlArrayItem("student_certificate")]
        public List<StudentCertificate> Certificates { get; set; }
    }
}
