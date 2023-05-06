using System;
using System.Xml.Serialization;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionBatchqueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelversionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// jsonString，不涉及商户敏感信息
        /// </summary>
        [XmlElement("model_version")]
        public string ModelVersion { get; set; }
    }
}
