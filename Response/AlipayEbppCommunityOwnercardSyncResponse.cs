using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardSyncResponse.
    /// </summary>
    public class AlipayEbppCommunityOwnercardSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝证件id
        /// </summary>
        [XmlElement("alipay_card_id")]
        public string AlipayCardId { get; set; }
    }
}
