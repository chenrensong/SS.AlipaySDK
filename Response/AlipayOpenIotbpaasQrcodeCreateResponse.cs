using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenIotbpaasQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码图片url，存储在内部oss平台
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
