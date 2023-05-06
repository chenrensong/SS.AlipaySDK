using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyModifyResponse.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
