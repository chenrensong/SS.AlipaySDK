using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskremarkCreateResponse.
    /// </summary>
    public class AlipayCommerceFixTaskremarkCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功的备注id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
