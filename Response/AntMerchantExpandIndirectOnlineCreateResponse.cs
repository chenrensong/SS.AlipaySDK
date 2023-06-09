using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectOnlineCreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectOnlineCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
