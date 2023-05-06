using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcapiDriverlicenseIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcapiDriverlicenseIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
