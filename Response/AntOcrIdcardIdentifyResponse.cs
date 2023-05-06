using System;
using System.Xml.Serialization;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntOcrIdcardIdentifyResponse.
    /// </summary>
    public class AntOcrIdcardIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
