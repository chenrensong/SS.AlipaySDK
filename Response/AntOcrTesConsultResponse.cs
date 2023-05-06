using System;
using System.Xml.Serialization;
using SS.AlipaySDKaySDK.Domain;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntOcrTesConsultResponse.
    /// </summary>
    public class AntOcrTesConsultResponse : AopResponse
    {
        /// <summary>
        /// q
        /// </summary>
        [XmlElement("hhgghfghj")]
        public AccessParams Hhgghfghj { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("ppds")]
        public string Ppds { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_3")]
        public MerchantCard Test3 { get; set; }
    }
}
