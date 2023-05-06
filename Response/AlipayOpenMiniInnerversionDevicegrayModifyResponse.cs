using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionDevicegrayModifyResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionDevicegrayModifyResponse : AopResponse
    {
        /// <summary>
        /// 灰度code
        /// </summary>
        [XmlElement("gray_code")]
        public string GrayCode { get; set; }
    }
}
