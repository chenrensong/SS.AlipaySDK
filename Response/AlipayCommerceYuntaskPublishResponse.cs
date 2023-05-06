using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskPublishResponse.
    /// </summary>
    public class AlipayCommerceYuntaskPublishResponse : AopResponse
    {
        /// <summary>
        /// 执行成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
