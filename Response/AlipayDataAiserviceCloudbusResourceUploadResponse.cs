using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceUploadResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceUploadResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
