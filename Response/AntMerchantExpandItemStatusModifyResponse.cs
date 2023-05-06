using System;
using System.Xml.Serialization;

namespace SS.AlipaySDKaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandItemStatusModifyResponse.
    /// </summary>
    public class AntMerchantExpandItemStatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
