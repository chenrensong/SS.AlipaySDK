using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceCodeRecoResponse.
    /// </summary>
    public class AlipayDataDataserviceCodeRecoResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public AlipayCodeRecoResult Result { get; set; }
    }
}
