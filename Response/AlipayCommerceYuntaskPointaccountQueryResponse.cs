using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskPointaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskPointaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 积分余额
        /// </summary>
        [XmlElement("available_amount")]
        public long AvailableAmount { get; set; }
    }
}
