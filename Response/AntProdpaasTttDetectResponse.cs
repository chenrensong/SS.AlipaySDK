using System;
using System.Xml.Serialization;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntProdpaasTttDetectResponse.
    /// </summary>
    public class AntProdpaasTttDetectResponse : AopResponse
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oo")]
        public string Oo { get; set; }
    }
}
