using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasDevicecodeCreateResponse.
    /// </summary>
    public class AlipayOpenIotbpaasDevicecodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 设备短码，由码平台生成，同一类设备的短码相同
        /// </summary>
        [XmlElement("short_code")]
        public string ShortCode { get; set; }
    }
}
