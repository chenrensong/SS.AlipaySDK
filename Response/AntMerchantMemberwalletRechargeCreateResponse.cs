using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantMemberwalletRechargeCreateResponse.
    /// </summary>
    public class AntMerchantMemberwalletRechargeCreateResponse : AopResponse
    {
        /// <summary>
        /// 充值订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
