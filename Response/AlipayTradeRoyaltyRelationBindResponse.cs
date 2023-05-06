using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBindResponse.
    /// </summary>
    public class AlipayTradeRoyaltyRelationBindResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：分账关系绑定成功； FAIL：分账关系绑定失败。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
