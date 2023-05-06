using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskConfirmResponse.
    /// </summary>
    public class AlipayCommerceYuntaskConfirmResponse : AopResponse
    {
        /// <summary>
        /// 执行成功结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
