using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSpIsvSignauthCreateResponse.
    /// </summary>
    public class AlipayOpenSpIsvSignauthCreateResponse : AopResponse
    {
        /// <summary>
        /// 签约授权一体化主单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
