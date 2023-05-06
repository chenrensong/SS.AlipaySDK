using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOcrMobileInitializeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasOcrMobileInitializeResponse : AopResponse
    {
        /// <summary>
        /// OCR识别流水ID，计费依据，请保留方便排查问题
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
