using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCreateResponse.
    /// </summary>
    public class AlipayBossFncSettleSettlementbillCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回参数
        /// </summary>
        [XmlElement("result_set")]
        public SettlementbillOpenApiDTO ResultSet { get; set; }
    }
}
