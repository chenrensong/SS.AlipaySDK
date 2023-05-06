using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOcrServerDetectResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasOcrServerDetectResponse : AopResponse
    {
        /// <summary>
        /// OCR识别单据号，计费依据，请保留以便排查问题。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// OCR识别结果
        /// </summary>
        [XmlElement("ocr_data")]
        public string OcrData { get; set; }
    }
}
